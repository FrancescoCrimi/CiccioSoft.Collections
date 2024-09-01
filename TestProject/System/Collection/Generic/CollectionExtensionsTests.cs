// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xunit;

namespace System.Collections.Tests
{
    public class CollectionExtensionsTests
    {
        [Fact]
        public void AsReadOnly_TurnsIListIntoReadOnlyCollection()
        {
            IList<string> list = new List<string> { "A", "B" };
            ReadOnlyCollection<string> readOnlyCollection = list.AsReadOnly();
            Assert.NotNull(readOnlyCollection);
            CollectionAsserts.Equal(list, readOnlyCollection);
        }

        [Fact]
        public void AsReadOnly_NullIList_ThrowsArgumentNullException()
        {
            IList<string> list = null;
            Assert.Throws<ArgumentNullException>("list", () => list.AsReadOnly());
        }
    }
}
