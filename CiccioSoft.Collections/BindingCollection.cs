// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// Francesco Crimi francrim@gmail.com

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

namespace CiccioSoft.Collections.Generic
{
    [Serializable]
    public class BindingCollection<T> : Collection<T>, IBindingList, IRaiseItemChangedEvents, IReadOnlyList<T>
    {
        private bool raiseItemChangedEvents; // Do not rename (binary serialization)

        [NonSerialized]
        private PropertyDescriptorCollection _itemTypeProperties;

        [NonSerialized]
        private PropertyChangedEventHandler _propertyChangedEventHandler;

        [NonSerialized]
        private ListChangedEventHandler _onListChanged;

        [NonSerialized]
        private int _lastChangeIndex = -1;


        #region Constructors

        public BindingCollection() => Initialize();

        public BindingCollection(IList<T> list) : base(list)
        {
            Initialize();
        }

        public BindingCollection(IEnumerable<T> collection) : base(new List<T>(collection))
        {
            Initialize();
        }

        public BindingCollection(int capacity) : base(new List<T>(capacity))
        {
            Initialize();
        }

        private void Initialize()
        {
            if (typeof(INotifyPropertyChanged).IsAssignableFrom(typeof(T)))
            {
                raiseItemChangedEvents = true;
                foreach (T item in Items)
                {
                    HookPropertyChanged(item);
                }
            }
        }

        #endregion

        #region Collection<T> overrides

        protected override void ClearItems()
        {
            if (raiseItemChangedEvents)
            {
                foreach (T item in Items)
                {
                    UnhookPropertyChanged(item);
                }
            }
            base.ClearItems();
            FireListChanged(ListChangedType.Reset, -1);
        }

        protected override void InsertItem(int index, T item)
        {
            base.InsertItem(index, item);
            if (raiseItemChangedEvents)
            {
                HookPropertyChanged(item);
            }
            FireListChanged(ListChangedType.ItemAdded, index);
        }

        protected override void RemoveItem(int index)
        {
            if (raiseItemChangedEvents)
            {
                UnhookPropertyChanged(this[index]);
            }
            base.RemoveItem(index);
            FireListChanged(ListChangedType.ItemDeleted, index);
        }

        protected override void SetItem(int index, T item)
        {
            if (raiseItemChangedEvents)
            {
                UnhookPropertyChanged(this[index]);
            }

            base.SetItem(index, item);

            if (raiseItemChangedEvents)
            {
                HookPropertyChanged(item);
            }

            FireListChanged(ListChangedType.ItemChanged, index);
        }

        #endregion

        #region ListChanged event

        public event ListChangedEventHandler ListChanged
        {
            add => _onListChanged += value;
            remove => _onListChanged -= value;
        }

        protected virtual void OnListChanged(ListChangedEventArgs e)
            => _onListChanged?.Invoke(this, e);

        private void ResetBindings()
            => FireListChanged(ListChangedType.Reset, -1);

        private void FireListChanged(ListChangedType type, int index)
        {
            OnListChanged(new ListChangedEventArgs(type, index));
        }

        #endregion

        #region Property Change Support

        private void HookPropertyChanged(T item)
        {
            if (item is INotifyPropertyChanged inpc)
            {
                if (_propertyChangedEventHandler == null)
                {
                    _propertyChangedEventHandler = new PropertyChangedEventHandler(Child_PropertyChanged);
                }
                inpc.PropertyChanged += _propertyChangedEventHandler;
            }
        }

        private void UnhookPropertyChanged(T item)
        {
            if (item is INotifyPropertyChanged inpc && _propertyChangedEventHandler != null)
            {
                inpc.PropertyChanged -= _propertyChangedEventHandler;
            }
        }

        private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender == null || e == null || string.IsNullOrEmpty(e.PropertyName))
            {
                ResetBindings();
            }
            else
            {
                T item;

                try
                {
                    item = (T)sender;
                }
                catch (InvalidCastException)
                {
                    ResetBindings();
                    return;
                }

                int pos = _lastChangeIndex;

                if (pos < 0 || pos >= Count || !this[pos].Equals(item))
                {
                    pos = IndexOf(item);
                    _lastChangeIndex = pos;
                }

                if (pos == -1)
                {
                    UnhookPropertyChanged(item);
                    ResetBindings();
                }
                else
                {
                    if (null == _itemTypeProperties)
                    {
                        _itemTypeProperties = TypeDescriptor.GetProperties(typeof(T));
                        Debug.Assert(_itemTypeProperties != null);
                    }
                    PropertyDescriptor pd = _itemTypeProperties.Find(e.PropertyName, true);
                    ListChangedEventArgs args = new ListChangedEventArgs(ListChangedType.ItemChanged, pos, pd);
                    OnListChanged(args);
                }
            }
        }

        #endregion

        #region IBindingList interface           

        object IBindingList.AddNew() => throw new NotSupportedException();

        bool IBindingList.AllowNew => false;

        bool IBindingList.AllowEdit => true;

        bool IBindingList.AllowRemove => true;

        bool IBindingList.SupportsChangeNotification => true;

        bool IBindingList.SupportsSearching => false;

        bool IBindingList.SupportsSorting => false;

        bool IBindingList.IsSorted => false;

        PropertyDescriptor IBindingList.SortProperty => null;

        ListSortDirection IBindingList.SortDirection => ListSortDirection.Ascending;

        void IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction)
        {
            throw new NotSupportedException();
        }

        void IBindingList.RemoveSort()
        {
            throw new NotSupportedException();
        }

        int IBindingList.Find(PropertyDescriptor prop, object key)
        {
            throw new NotSupportedException();
        }

        void IBindingList.AddIndex(PropertyDescriptor prop)
        {
            // Not supported
        }

        void IBindingList.RemoveIndex(PropertyDescriptor prop)
        {
            // Not supported
        }

        #endregion

        #region IRaiseItemChangedEvents interface

        bool IRaiseItemChangedEvents.RaisesItemChangedEvents => raiseItemChangedEvents;

        #endregion

        public bool IsReadOnly => Items.IsReadOnly;
    }
}
