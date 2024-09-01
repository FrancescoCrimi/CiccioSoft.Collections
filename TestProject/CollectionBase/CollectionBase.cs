using System;
using System.Collections.Generic;

namespace CiccioSoft.Collections.Tests.CollectionBase
{
    public class CollectionBase_Test_string : CollectionBase_Tests<string>
    {
        protected override string CreateT(int seed)
        {
            int stringLength = seed % 10 + 5;
            Random rand = new Random(seed);
            byte[] bytes = new byte[stringLength];
            rand.NextBytes(bytes);
            return Convert.ToBase64String(bytes);
        }
    }

    public class CollectionBase_Test_int : CollectionBase_Tests<int>
    {
        protected override int CreateT(int seed)
        {
            Random rand = new Random(seed);
            return rand.Next();
        }
    }

    public class CollectionBase_Tests_string_ReadOnly : CollectionBase_Tests<string>
    {
        protected override string CreateT(int seed)
        {
            int stringLength = seed % 10 + 5;
            Random rand = new Random(seed);
            byte[] bytes = new byte[stringLength];
            rand.NextBytes(bytes);
            return Convert.ToBase64String(bytes);
        }

        protected override bool IsReadOnly => true;

        protected override IList<string> GenericIListFactory(int setLength)
        {
            return GenericListFactory(setLength).AsReadOnly();
        }

        protected override IList<string> GenericIListFactory()
        {
            return GenericListFactory().AsReadOnly();
        }

        protected override IEnumerable<ModifyEnumerable> GetModifyEnumerables(ModifyOperation operations) => new List<ModifyEnumerable>();

        protected override bool Enumerator_Empty_Current_UndefinedOperation_Throws => true;
    }

    public class CollectionBase_Tests_int_ReadOnly : CollectionBase_Tests<int>
    {
        protected override int CreateT(int seed)
        {
            Random rand = new Random(seed);
            return rand.Next();
        }

        protected override bool IsReadOnly => true;

        protected override IList<int> GenericIListFactory(int setLength)
        {
            return GenericListFactory(setLength).AsReadOnly();
        }

        protected override IList<int> GenericIListFactory()
        {
            return GenericListFactory().AsReadOnly();
        }

        protected override IEnumerable<ModifyEnumerable> GetModifyEnumerables(ModifyOperation operations) => new List<ModifyEnumerable>();

        protected override bool Enumerator_Empty_Current_UndefinedOperation_Throws => true;
    }
}
