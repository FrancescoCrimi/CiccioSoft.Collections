using System;

namespace CiccioSoft.Collections.Observable
{
    public static class CollectionExtensions
    {
        //public static ReadOnlyObservableCollection<T> AsReadOnly<T>(this ObservableCollection<T> collection)
        //{
        //    if (collection == null)
        //    {
        //        throw new ArgumentNullException(nameof(collection), "The ObservableCollection cannot be null.");
        //    }
        //    return new ReadOnlyObservableCollection<T>(collection);
        //}

        //public static ReadOnlyObservableCollection<T> AsReadOnly<T>(this System.Collections.ObjectModel.ObservableCollection<T> collection)
        //{
        //    if (collection == null)
        //    {
        //        throw new ArgumentNullException(nameof(collection), "The ObservableCollection cannot be null.");
        //    }
        //    return new ReadOnlyObservableCollection<T>(collection);
        //}

        public static ReadOnlyObservableSet<T> AsReadOnly<T>(this ObservableHashSet<T> set)
        {
            if (set == null)
            {
                throw new ArgumentNullException(nameof(set), "The ObservableSet cannot be null.");
            }
            return new ReadOnlyObservableSet<T>(set);
        }
    }
}
