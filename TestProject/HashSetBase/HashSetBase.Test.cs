using CiccioSoft.Collections.Collections;
using System;
using System.Collections.Generic;
using System.Collections.Tests;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiccioSoft.Collections.Tests.HashSetBase
{
    public abstract class HashSetBase_Test<T> : ISet_Generic_Tests<T>
    {
        #region ISet<T> Helper Methods

        protected override bool Enumerator_Empty_UsesSingletonInstance => true;
        protected override bool Enumerator_Empty_Current_UndefinedOperation_Throws => true;

        protected override bool ResetImplemented => true;

        protected override ModifyOperation ModifyEnumeratorThrows => PlatformDetection.IsNetFramework ? base.ModifyEnumeratorThrows : (base.ModifyEnumeratorAllowed & ~(ModifyOperation.Remove | ModifyOperation.Clear));

        protected override ModifyOperation ModifyEnumeratorAllowed => PlatformDetection.IsNetFramework ? base.ModifyEnumeratorAllowed : ModifyOperation.Overwrite | ModifyOperation.Remove | ModifyOperation.Clear;

        protected override ISet<T> GenericISetFactory()
        {
            return new HashSetBase<T>();
        }

        #endregion
    }
}
