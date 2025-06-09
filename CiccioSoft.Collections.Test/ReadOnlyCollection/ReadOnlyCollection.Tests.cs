// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace CiccioSoft.Collections.Tests.ReadOnlyCollection
{
    public class ReadOnlyCollection_Test
    {
        [Fact]
        public void Ctor_NullSet_ThrowsArgumentNullException()
        {
            AssertExtensions.Throws<ArgumentNullException>("list", () => new ReadOnlyCollection<int>(null));
        }

        [Fact]
        public void Ctor_SetProperty_Roundtrips()
        {
            var set = new Collection<int>();
            Assert.Same(set, new DerivedReadOnlyCollection<int>(set).List);
        }

        //[Fact]
        //public void Empty_EmptyAndIdempotent()
        //{
        //    Assert.Same(ReadOnlyCollection<int>.Empty, ReadOnlyCollection<int>.Empty);
        //    Assert.Empty(ReadOnlyCollection<int>.Empty);
        //    Assert.Same(ReadOnlyCollection<int>.Empty.GetEnumerator(), ReadOnlyCollection<int>.Empty.GetEnumerator());
        //}

        [Fact]
        public void MembersDelegateToWrappedSet()
        {
            var set = new ReadOnlyCollection<int>(new Collection<int>() { 1, 2, 3 });

            Assert.True(set.Contains(2));
            Assert.False(set.Contains(4));

            Assert.Equal(3, set.Count);

            //Assert.True(set.IsProperSubsetOf([1, 2, 3, 4]));
            //Assert.False(set.IsProperSubsetOf([1, 2, 5]));

            //Assert.True(set.IsProperSupersetOf([1, 2]));
            //Assert.False(set.IsProperSupersetOf([1, 4]));

            //Assert.True(set.IsSubsetOf([1, 2, 3, 4]));
            //Assert.False(set.IsSubsetOf([1, 2, 5]));

            //Assert.True(set.IsSupersetOf([1, 2]));
            //Assert.False(set.IsSupersetOf([1, 4]));

            //Assert.True(set.Overlaps([-1, 0, 1]));
            //Assert.False(set.Overlaps([-1, 0]));

            //Assert.True(set.SetEquals([1, 2, 3]));
            //Assert.False(set.SetEquals([1, 2, 4]));

            int[] result = new int[3];
            ((ICollection<int>)set).CopyTo(result, 0);
            Assert.Equal(result, new int[] { 1, 2, 3 });

            //Array.Clear(result);
            ((IList)result).Clear();
            ((ICollection)set).CopyTo(result, 0);
            Assert.Equal(result, new int[] { 1, 2, 3 });

            Assert.NotNull(set.GetEnumerator());
        }

        [Fact]
        public void ChangesToUnderlyingSetReflected()
        {
            var set = new Collection<int> { 1, 2, 3 };
            var readOnlySet = new ReadOnlyCollection<int>(set);

            set.Add(4);
            Assert.Equal(4, readOnlySet.Count);
            Assert.True(readOnlySet.Contains(4));

            set.Remove(2);
            Assert.Equal(3, readOnlySet.Count);
            Assert.False(readOnlySet.Contains(2));
        }

        [Fact]
        public void IsReadOnly_True()
        {
            var set = new ReadOnlyCollection<int>(new Collection<int> { 1, 2, 3 });
            Assert.True(((ICollection<int>)set).IsReadOnly);
        }

        [Fact]
        public void MutationThrows_CollectionUnmodified()
        {
            var set = new Collection<int> { 1, 2, 3 };
            var readOnlySet = new ReadOnlyCollection<int>(set);

            Assert.Throws<NotSupportedException>(() => ((ICollection<int>)readOnlySet).Add(4));
            Assert.Throws<NotSupportedException>(() => ((ICollection<int>)readOnlySet).Remove(1));
            Assert.Throws<NotSupportedException>(() => ((ICollection<int>)readOnlySet).Clear());

            //Assert.Throws<NotSupportedException>(() => ((ISet<int>)readOnlySet).Add(4));
            //Assert.Throws<NotSupportedException>(() => ((ISet<int>)readOnlySet).ExceptWith([1, 2, 3]));
            //Assert.Throws<NotSupportedException>(() => ((ISet<int>)readOnlySet).IntersectWith([1, 2, 3]));
            //Assert.Throws<NotSupportedException>(() => ((ISet<int>)readOnlySet).SymmetricExceptWith([1, 2, 3]));
            //Assert.Throws<NotSupportedException>(() => ((ISet<int>)readOnlySet).UnionWith([1, 2, 3]));

            Assert.Equal(3, set.Count);
        }

        [Fact]
        public void ICollection_Synchronization()
        {
            var list = new Collection<int> { 1, 2, 3 };
            var rolist = new ReadOnlyCollection<int>(list);

            Assert.False(((ICollection)rolist).IsSynchronized);
            Assert.Same(((ICollection)list).SyncRoot, ((ICollection)rolist).SyncRoot);
        }

        private class DerivedReadOnlyCollection<T> : ReadOnlyCollection<T>
        {
            public DerivedReadOnlyCollection(Collection<T> set) : base(set) { }

            public new IList<T> List => base._list;
        }
    }
}
