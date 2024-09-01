using System;
using System.Collections.Generic;
using System.Collections.Tests;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiccioSoft.Collections.Tests.CollectionBase
{
    public abstract partial class CollectionBase_Tests<T> : IList_Generic_Tests<T>
    {
        #region IList<T> Helper Methods

        protected override bool Enumerator_Empty_UsesSingletonInstance => true;
        protected override bool Enumerator_Empty_Current_UndefinedOperation_Throws => true;
        protected override bool Enumerator_Empty_ModifiedDuringEnumeration_ThrowsInvalidOperationException => false;

        protected override IList<T> GenericIListFactory()
        {
            return GenericListFactory();
        }

        protected override IList<T> GenericIListFactory(int count)
        {
            return GenericListFactory(count);
        }

        #endregion


        #region CollectionBase<T> Helper Methods

        protected virtual CollectionBase<T> GenericListFactory()
        {
            return new CollectionBase<T>();
        }

        protected virtual CollectionBase<T> GenericListFactory(int count)
        {
            IEnumerable<T> toCreateFrom = CreateEnumerable(EnumerableType.List, null, count, 0, 0);
            return new CollectionBase<T>(new List<T>(toCreateFrom));
        }

        #endregion
    }
}
