using System;

namespace CiccioSoft.Collections.Binding
{
    public static class CollectionExtensions
    {
        //public static ReadOnlyBindingList<T> AsReadOnly<T>(this BindingList<T> list)
        //{
        //    if (list == null)
        //    {
        //        throw new ArgumentNullException(nameof(list), "The BindingList cannot be null.");
        //    }
        //    return new ReadOnlyBindingList<T>(list);
        //}

        public static ReadOnlyBindingList<T> AsReadOnly<T>(this System.ComponentModel.BindingList<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list), "The BindingList cannot be null.");
            }
            return new ReadOnlyBindingList<T>(list);
        }

        public static ReadOnlyBindingSet<T> AsReadOnly<T>(this BindingHashSet<T> set)
        {
            if (set == null)
            {
                throw new ArgumentNullException(nameof(set), "The BindingSet cannot be null.");
            }
            return new ReadOnlyBindingSet<T>(set);
        }
    }
}
