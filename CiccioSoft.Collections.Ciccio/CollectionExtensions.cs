using System;

namespace CiccioSoft.Collections.Ciccio
{
    public static class CollectionExtensions
    {
        public static ReadOnlyCiccioList<T> AsReadOnly<T>(this CiccioList<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list), "The CiccioList cannot be null.");
            }
            return new ReadOnlyCiccioList<T>(list);
        }

        public static ReadOnlyCiccioSet<T> AsReadOnly<T>(this CiccioSet<T> set)
        {
            if (set == null)
            {
                throw new ArgumentNullException(nameof(set), "The CiccioSet cannot be null.");
            }
            return new ReadOnlyCiccioSet<T>(set);
        }
    }
}
