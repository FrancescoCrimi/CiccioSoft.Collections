// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;

namespace CiccioSoft.Collections
{
    /// <summary>
    /// Read-only wrapper around an ObservableCollection.
    /// </summary>
    [Serializable]
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class ReadOnlyObservableCollection<T> : ReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of ReadOnlyObservableCollection that
        /// wraps the given ObservableCollection.
        /// </summary>
        public ReadOnlyObservableCollection(ObservableCollection<T> list) : base(list)
        {
            list.CollectionChanged += new NotifyCollectionChangedEventHandler(HandleCollectionChanged);
            ((INotifyPropertyChanged)list).PropertyChanged += new PropertyChangedEventHandler(HandlePropertyChanged);
            //((INotifyCollectionChanged)Items).CollectionChanged += new NotifyCollectionChangedEventHandler(HandleCollectionChanged);
            //((INotifyPropertyChanged)Items).PropertyChanged += new PropertyChangedEventHandler(HandlePropertyChanged);

        }

        ///// <summary>Gets an empty <see cref="ReadOnlyObservableCollection{T}"/>.</summary>
        ///// <value>An empty <see cref="ReadOnlyObservableCollection{T}"/>.</value>
        ///// <remarks>The returned instance is immutable and will always be empty.</remarks>
        //public static new ReadOnlyObservableCollection<T> Empty { get; } = new ReadOnlyObservableCollection<T>(new ObservableCollection<T>());

        #endregion

        #region CollectionChanged

        /// <summary>
        /// Occurs when the collection changes, either by adding or removing an item.
        /// </summary>
        /// <remarks>
        /// see <seealso cref="INotifyCollectionChanged"/>
        /// </remarks>
        [field: NonSerialized]
        public event NotifyCollectionChangedEventHandler? CollectionChanged;

        /// <summary>
        /// raise CollectionChanged event to any listeners
        /// </summary>
        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args)
        {
            CollectionChanged?.Invoke(this, args);
        }

        private void HandleCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            OnCollectionChanged(e);
        }

        #endregion

        #region PropertyChanged

        /// <summary>
        /// Occurs when a property changes.
        /// </summary>
        /// <remarks>
        /// see <seealso cref="INotifyPropertyChanged"/>
        /// </remarks>
        [field: NonSerialized]
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// raise PropertyChanged event to any listeners
        /// </summary>
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            PropertyChanged?.Invoke(this, args);
        }

        private void HandlePropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(e);
        }

        #endregion
    }
}
