// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Collections.Tests;
using Xunit;

namespace CiccioSoft.Collections.Tests.HashSetBase
{
    public abstract partial class HashSetBase_Test<T> : ISet_Generic_Tests<T>
    {
        [Fact]
        public void Constructor_Generic_ISet()
        {
            ISet<string> set = new HashSet<string>();
            set.Add("foo");
            ISet<string> setBase = new HashSetBase<string>(set);
            Assert.False(setBase.IsReadOnly);
            Assert.Contains("foo", setBase);
            set.Add("bar");
            Assert.Contains("bar", setBase);
            setBase.Add("baz");
            Assert.Contains("baz", set);
        }

        [Fact]
        public void Constructor_Array()
        {
            string[] arr = ["foo"];
            ISet<string> setBase = new HashSetBase<string>(arr);
            Assert.False(setBase.IsReadOnly);
            Assert.Contains("foo", setBase);
            setBase.Add("bar");
            Assert.Contains("bar", setBase);
        }
    }
}
