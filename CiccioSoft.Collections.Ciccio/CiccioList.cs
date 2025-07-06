// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;

namespace CiccioSoft.Collections.Ciccio
{
    [Serializable]
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class CiccioList<T> : CiccioSoft.Collections.List<T>, INotifyCollectionChanged, INotifyPropertyChanged, IBindingList, IRaiseItemChangedEvents
    {
        [NonSerialized]
        private int _blockReentrancyCount;

        private bool raiseListChangedEvents = true; // Do not rename (binary serialization)
        private bool raiseItemChangedEvents; // Do not rename (binary serialization)

        [NonSerialized]
        private PropertyDescriptorCollection? _itemTypeProperties;

        [NonSerialized]
        private PropertyChangedEventHandler? _propertyChangedEventHandler;

        [NonSerialized]
        private ListChangedEventHandler? _onListChanged;

        [NonSerialized]
        private int _lastChangeIndex = -1;

        #region Constructors

        public CiccioList() => Initialize();

        public CiccioList(IEnumerable<T> enumerable) : base(enumerable)
        {
            Initialize();
        }

        public CiccioList(int capacity) : base(capacity)
        {
            Initialize();
        }

        private void Initialize()
        {
            // Check for INotifyPropertyChanged
            if (typeof(INotifyPropertyChanged).IsAssignableFrom(typeof(T)))
            {
                // Supports INotifyPropertyChanged
                raiseItemChangedEvents = true;

                // Loop thru the items already in the collection and hook their change notification.
                foreach (T item in Items)
                {
                    HookPropertyChanged(item);
                }
            }
        }

        #endregion


        #region Protected Override Methods

        protected override void ClearItems()
        {
            CheckReentrancy();

            if (raiseItemChangedEvents)
            {
                foreach (T item in Items)
                {
                    UnhookPropertyChanged(item);
                }
            }

            base.ClearItems();

            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionReset();

            FireListChanged(ListChangedType.Reset, -1);
        }

        protected override void RemoveItem(int index)
        {
            CheckReentrancy();
            T removedItem = this[index];

            if (raiseItemChangedEvents)
            {
                UnhookPropertyChanged(this[index]);
            }

            base.RemoveItem(index);

            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionChanged(NotifyCollectionChangedAction.Remove, removedItem, index);

            FireListChanged(ListChangedType.ItemDeleted, index);
        }

        protected override void InsertItem(int index, T item)
        {
            CheckReentrancy();

            base.InsertItem(index, item);

            if (raiseItemChangedEvents)
            {
                HookPropertyChanged(item);
            }

            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionChanged(NotifyCollectionChangedAction.Add, item, index);

            FireListChanged(ListChangedType.ItemAdded, index);
        }

        protected override void SetItem(int index, T item)
        {
            CheckReentrancy();
            T originalItem = this[index];

            if (raiseItemChangedEvents)
            {
                UnhookPropertyChanged(this[index]);
            }

            base.SetItem(index, item);

            if (raiseItemChangedEvents)
            {
                HookPropertyChanged(item);
            }

            OnIndexerPropertyChanged();
            OnCollectionChanged(NotifyCollectionChangedAction.Replace, originalItem, item, index);

            FireListChanged(ListChangedType.ItemChanged, index);
        }

        #endregion


        #region INotifyPropertyChanged interface

        /// <summary>
        /// PropertyChanged event (per <see cref="INotifyPropertyChanged" />).
        /// </summary>
        event PropertyChangedEventHandler? INotifyPropertyChanged.PropertyChanged
        {
            add => PropertyChanged += value;
            remove => PropertyChanged -= value;
        }

        /// <summary>
        /// Raises a PropertyChanged event (per <see cref="INotifyPropertyChanged" />).
        /// </summary>
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        /// <summary>
        /// PropertyChanged event (per <see cref="INotifyPropertyChanged" />).
        /// </summary>
        [field: NonSerialized]
        protected virtual event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Helper to raise a PropertyChanged event for the Count property
        /// </summary>
        private void OnCountPropertyChanged() => OnPropertyChanged(EventArgsCache.CountPropertyChanged);

        /// <summary>
        /// Helper to raise a PropertyChanged event for the Indexer property
        /// </summary>
        private void OnIndexerPropertyChanged() => OnPropertyChanged(EventArgsCache.IndexerPropertyChanged);

        #endregion


        #region INotifyCollectionChanged interface

        /// <summary>
        /// Occurs when the collection changes, either by adding or removing an item.
        /// </summary>
        [field: NonSerialized]
        public virtual event NotifyCollectionChangedEventHandler? CollectionChanged;

        /// <summary>
        /// Raise CollectionChanged event to any listeners.
        /// Properties/methods modifying this ObservableCollection will raise
        /// a collection changed event through this virtual method.
        /// </summary>
        /// <remarks>
        /// When overriding this method, either call its base implementation
        /// to guard against reentrant collection changes.
        /// </remarks>
        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            NotifyCollectionChangedEventHandler? handler = CollectionChanged;
            if (handler != null)
            {
                // Not calling BlockReentrancy() here to avoid the SimpleMonitor allocation.
                _blockReentrancyCount++;
                try
                {
                    handler(this, e);
                }
                finally
                {
                    _blockReentrancyCount--;
                }
            }
        }

        /// <summary> Check and assert for reentrant attempts to change this collection. </summary>
        /// <exception cref="InvalidOperationException"> raised when changing the collection
        /// while another collection change is still being notified to other listeners </exception>
        protected void CheckReentrancy()
        {
            if (_blockReentrancyCount > 0)
            {
                // we can allow changes if there's only one listener - the problem
                // only arises if reentrant changes make the original event args
                // invalid for later listeners.  This keeps existing code working
                // (e.g. Selector.SelectedItems).
                if (CollectionChanged?.GetInvocationList().Length > 1)
                    throw new InvalidOperationException("Cannot change ObservableCollection during a CollectionChanged event.");
            }
        }

        /// <summary>
        /// Helper to raise CollectionChanged event to any listeners
        /// </summary>
        private void OnCollectionChanged(NotifyCollectionChangedAction action, object? item, int index)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, item, index));
        }

        /// <summary>
        /// Helper to raise CollectionChanged event to any listeners
        /// </summary>
        private void OnCollectionChanged(NotifyCollectionChangedAction action, object? item, int index, int oldIndex)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, item, index, oldIndex));
        }

        /// <summary>
        /// Helper to raise CollectionChanged event to any listeners
        /// </summary>
        private void OnCollectionChanged(NotifyCollectionChangedAction action, object? oldItem, object? newItem, int index)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, newItem, oldItem, index));
        }

        /// <summary>
        /// Helper to raise CollectionChanged event with action == Reset to any listeners
        /// </summary>
        private void OnCollectionReset() => OnCollectionChanged(EventArgsCache.ResetCollectionChanged);

        #endregion


        #region ListChanged event

        /// <summary>
        /// Event that reports changes to the list or to items in the list.
        /// </summary>
        public event ListChangedEventHandler ListChanged
        {
            add => _onListChanged += value;
            remove => _onListChanged -= value;
        }

        /// <summary>
        /// Raises the ListChanged event.
        /// </summary>
        protected virtual void OnListChanged(ListChangedEventArgs e) => _onListChanged?.Invoke(this, e);

        public bool RaiseListChangedEvents
        {
            get => raiseListChangedEvents;
            set => raiseListChangedEvents = value;
        }

        public void ResetBindings() => FireListChanged(ListChangedType.Reset, -1);

        public void ResetItem(int position)
        {
            FireListChanged(ListChangedType.ItemChanged, position);
        }

        // Private helper method
        private void FireListChanged(ListChangedType type, int index)
        {
            if (raiseListChangedEvents)
            {
                OnListChanged(new ListChangedEventArgs(type, index));
            }
        }

        #endregion


        #region IBindingList interface

        public T AddNew() => (T)(this as IBindingList).AddNew()!;

        object? IBindingList.AddNew()
            => throw new NotSupportedException();

        public bool AllowNew
            => false;

        bool IBindingList.AllowNew => AllowNew;

        public bool AllowEdit
            => true;

        bool IBindingList.AllowEdit => AllowEdit;

        public bool AllowRemove
            => true;

        bool IBindingList.AllowRemove => AllowRemove;

        bool IBindingList.SupportsChangeNotification => SupportsChangeNotificationCore;

        protected virtual bool SupportsChangeNotificationCore => true;

        bool IBindingList.SupportsSearching => SupportsSearchingCore;

        protected virtual bool SupportsSearchingCore => false;

        bool IBindingList.SupportsSorting => SupportsSortingCore;

        protected virtual bool SupportsSortingCore => false;

        bool IBindingList.IsSorted => IsSortedCore;

        protected virtual bool IsSortedCore => false;

        PropertyDescriptor? IBindingList.SortProperty => SortPropertyCore;

        protected virtual PropertyDescriptor? SortPropertyCore => null;

        ListSortDirection IBindingList.SortDirection => SortDirectionCore;

        protected virtual ListSortDirection SortDirectionCore => ListSortDirection.Ascending;

        void IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction)
        {
            ApplySortCore(prop, direction);
        }

        protected virtual void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            throw new NotSupportedException();
        }

        void IBindingList.RemoveSort() => RemoveSortCore();

        protected virtual void RemoveSortCore()
        {
            throw new NotSupportedException();
        }

        int IBindingList.Find(PropertyDescriptor prop, object key) => FindCore(prop, key);

        protected virtual int FindCore(PropertyDescriptor prop, object key)
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

        /// <summary>
        /// Returns false to indicate that BindingList&lt;T&gt; does NOT raise ListChanged events
        /// of type ItemChanged as a result of property changes on individual list items
        /// unless those items support INotifyPropertyChanged.
        /// </summary>
        bool IRaiseItemChangedEvents.RaisesItemChangedEvents => raiseItemChangedEvents;

        #endregion


        #region PropertyChanged Support

        private void HookPropertyChanged(T item)
        {
            // Note: inpc may be null if item is null, so always check.
            if (item is INotifyPropertyChanged inpc)
            {
                _propertyChangedEventHandler ??= new PropertyChangedEventHandler(Child_PropertyChanged);
                inpc.PropertyChanged += _propertyChangedEventHandler;
            }
        }

        private void UnhookPropertyChanged(T item)
        {
            // Note: inpc may be null if item is null, so always check.
            if (item is INotifyPropertyChanged inpc && _propertyChangedEventHandler != null)
            {
                inpc.PropertyChanged -= _propertyChangedEventHandler;
            }
        }

        private void Child_PropertyChanged(object? sender, PropertyChangedEventArgs? e)
        {
            if (RaiseListChangedEvents)
            {
                if (sender == null || e == null || string.IsNullOrEmpty(e.PropertyName))
                {
                    // Fire reset event (per INotifyPropertyChanged spec)
                    ResetBindings();
                }
                else
                {
                    // The change event is broken should someone pass an item to us that is not
                    // of type T. Still, if they do so, detect it and ignore. It is an incorrect
                    // and rare enough occurrence that we do not want to slow the mainline path
                    // with "is" checks.
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

                    // Find the position of the item. This should never be -1. If it is,
                    // somehow the item has been removed from our list without our knowledge.
                    int pos = _lastChangeIndex;

                    if (pos < 0 || pos >= Count || !this[pos]!.Equals(item))
                    {
                        pos = IndexOf(item);
                        _lastChangeIndex = pos;
                    }

                    if (pos == -1)
                    {
                        // The item was removed from the list but we still get change notifications or
                        // the sender is invalid and was never added to the list.
                        UnhookPropertyChanged(item);
                        ResetBindings();
                    }
                    else
                    {
                        // Get the property descriptor
                        if (null == _itemTypeProperties)
                        {
                            // Get Shape
                            _itemTypeProperties = TypeDescriptor.GetProperties(typeof(T));
                            Debug.Assert(_itemTypeProperties != null);
                        }

                        PropertyDescriptor? pd = _itemTypeProperties.Find(e.PropertyName, true);

                        // Create event args. If there was no matching property descriptor,
                        // we raise the list changed anyway.
                        ListChangedEventArgs args = new ListChangedEventArgs(ListChangedType.ItemChanged, pos, pd);

                        // Fire the ItemChanged event
                        OnListChanged(args);
                    }
                }
            }
        }

        #endregion
    }
}
