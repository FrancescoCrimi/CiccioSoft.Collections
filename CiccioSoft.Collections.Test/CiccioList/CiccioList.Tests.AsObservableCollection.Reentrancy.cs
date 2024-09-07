// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Xunit;

namespace CiccioSoft.Collections.Tests.CiccioList
{
    public partial class CiccioList_As_ObservableCollection
    {
        [Fact]
        public void Reentrancy_SingleListener_DoesNotThrow()
        {
            bool handlerCalled = false;

            var collection = new CiccioList<int>();
            collection.CollectionChanged += (sender, e) =>
            {
                if (!handlerCalled)
                {
                    handlerCalled = true;

                    // Single listener; does not throw.
                    collection.Add(2);
                }
            };
            collection.Add(1);

            Assert.True(handlerCalled);
            Assert.Equal(2, collection.Count);
            Assert.Equal(1, collection[0]);
            Assert.Equal(2, collection[1]);
        }

        [Fact]
        public void Reentrancy_MultipleListeners_Throws()
        {
            bool handler1Called = false;
            bool handler2Called = false;

            var collection = new CiccioList<int>();
            collection.CollectionChanged += (sender, e) => { handler1Called = true; };
            collection.CollectionChanged += (sender, e) =>
            {
                handler2Called = true;

                // More than one listener; throws.
                Assert.Throws<InvalidOperationException>(() => collection.Add(2));
            };
            collection.Add(1);

            Assert.True(handler1Called);
            Assert.True(handler2Called);
            Assert.Equal(1, collection.Count);
            Assert.Equal(1, collection[0]);
        }
    }
}
