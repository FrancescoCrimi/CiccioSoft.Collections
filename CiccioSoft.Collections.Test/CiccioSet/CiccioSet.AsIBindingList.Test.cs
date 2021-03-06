﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xunit;

namespace CiccioSoft.Collections.Generic.Test.CiccioSet
{
    public class CiccioSet_AsIBindingList_Test
    {
        [Fact]
        public void Ctor_Default()
        {
            var list = new CiccioSet<string>();
            IBindingList iBindingList = list;

            Assert.True(iBindingList.AllowEdit);
            Assert.False(iBindingList.AllowNew);
            Assert.True(iBindingList.AllowRemove);
            Assert.Equal(ListSortDirection.Ascending, iBindingList.SortDirection);
            Assert.True(iBindingList.SupportsChangeNotification);
            Assert.False(iBindingList.SupportsSearching);
            Assert.False(iBindingList.SupportsSorting);
            Assert.False(((IRaiseItemChangedEvents)list).RaisesItemChangedEvents);
        }

        [Fact]
        public void Ctor_FixedSizeIList()
        {
            var array = new string[10];
            var bindingList = new CiccioSet<string>(array);
            IBindingList iBindingList = bindingList;

            Assert.True(iBindingList.AllowEdit);
            Assert.False(iBindingList.AllowNew);
            Assert.True(iBindingList.AllowRemove);
            Assert.False(iBindingList.IsSorted);
            Assert.Equal(ListSortDirection.Ascending, iBindingList.SortDirection);
            Assert.True(iBindingList.SupportsChangeNotification);
            Assert.False(iBindingList.SupportsSearching);
            Assert.False(iBindingList.SupportsSorting);
            Assert.False(((IRaiseItemChangedEvents)bindingList).RaisesItemChangedEvents);
        }

        [Fact]
        public void Ctor_NonFixedSizeIList()
        {
            var list = new List<string>();
            var bindingList = new CiccioSet<string>(list);
            IBindingList iBindingList = bindingList;

            Assert.True(iBindingList.AllowEdit);
            Assert.False(iBindingList.AllowNew);
            Assert.True(iBindingList.AllowRemove);
            Assert.False(iBindingList.IsSorted);
            Assert.Equal(ListSortDirection.Ascending, iBindingList.SortDirection);
            Assert.True(iBindingList.SupportsChangeNotification);
            Assert.False(iBindingList.SupportsSearching);
            Assert.False(iBindingList.SupportsSorting);
            Assert.False(((IRaiseItemChangedEvents)bindingList).RaisesItemChangedEvents);
        }

        [Fact]
        public void Ctor_IReadOnlyList()
        {
            var list = new List<string>();
            var bindingList = new CiccioSet<string>(list);
            IBindingList iBindingList = bindingList;

            Assert.True(iBindingList.AllowEdit);
            Assert.False(iBindingList.AllowNew);
            Assert.True(iBindingList.AllowRemove);
            Assert.False(iBindingList.IsSorted);
            Assert.Equal(ListSortDirection.Ascending, iBindingList.SortDirection);
            Assert.True(iBindingList.SupportsChangeNotification);
            Assert.False(iBindingList.SupportsSearching);
            Assert.False(iBindingList.SupportsSorting);
            Assert.False(((IRaiseItemChangedEvents)bindingList).RaisesItemChangedEvents);
        }

        [Fact]
        public void Remove_Invoke_CallsListChanged()
        {
            var obj = new object();
            var list = new List<object> { obj };
            var bindingList = new CiccioSet<object>(list);

            bool calledListChanged = false;
            bindingList.ListChanged += (object sender, ListChangedEventArgs e) =>
            {
                calledListChanged = true;
                Assert.Equal(0, e.NewIndex);
                Assert.Equal(ListChangedType.ItemDeleted, e.ListChangedType);

                // The event is raised after the removal.
                Assert.Equal(0, bindingList.Count);
            };
            bindingList.Remove(obj);

            Assert.True(calledListChanged);
        }

        [Fact]
        public void Clear_Invoke_Success()
        {
            var bindingList = new CiccioSet<object> { new object(), new object() };

            bool calledListChanged = false;
            bindingList.ListChanged += (object sender, ListChangedEventArgs e) =>
            {
                calledListChanged = true;
                Assert.Equal(ListChangedType.Reset, e.ListChangedType);
                Assert.Equal(-1, e.NewIndex);
            };

            bindingList.Clear();
            Assert.True(calledListChanged);
            Assert.Empty(bindingList);
        }

        [Fact]
        public void Clear_INotifyPropertyChangedItems_RemovesPropertyChangedEventHandlers()
        {
            var item1 = new Item();
            var item2 = new Item();
            var list = new List<Item> { item1, item2, null };
            var bindingList = new CiccioSet<Item>(list);
            Assert.Equal(1, item1.InvocationList.Length);
            Assert.Equal(1, item2.InvocationList.Length);

            bool calledListChanged = false;
            bindingList.ListChanged += (object sender, ListChangedEventArgs e) =>
            {
                calledListChanged = true;
                Assert.Equal(ListChangedType.Reset, e.ListChangedType);
                Assert.Equal(-1, e.NewIndex);
            };

            bindingList.Clear();
            Assert.True(calledListChanged);
            Assert.Empty(bindingList);

            Assert.Null(item1.InvocationList);
            Assert.Null(item2.InvocationList);
        }

        [Fact]
        public void Remove_INotifyPropertyChangedItems_RemovesPropertyChangedEventHandlers()
        {
            var item = new Item();
            var bindingList = new CiccioSet<Item> { item };
            Assert.Equal(1, item.InvocationList.Length);

            bool calledListChanged = false;
            bindingList.ListChanged += (object sender, ListChangedEventArgs e) =>
            {
                calledListChanged = true;
                Assert.Equal(ListChangedType.ItemDeleted, e.ListChangedType);
                Assert.Equal(0, e.NewIndex);
            };

            bindingList.Remove(item);
            Assert.True(calledListChanged);
            Assert.Empty(bindingList);
            Assert.Null(item.InvocationList);
        }

        //[Fact]
        //public void ItemSet_Invoke_CallsListChanged()
        //{
        //    var bindingList = new CiccioSet<int> { 1 };

        //    bool calledListChanged = false;
        //    bindingList.ListChanged += (object sender, ListChangedEventArgs e) =>
        //    {
        //        calledListChanged = true;
        //        Assert.Equal(ListChangedType.ItemChanged, e.ListChangedType);
        //        Assert.Equal(0, e.NewIndex);
        //    };

        //    bindingList[0] = 2;
        //    Assert.True(calledListChanged);
        //    Assert.Equal(2, bindingList[0]);
        //}

        //[Fact]
        //public void ItemSet_INotifyPropertyChangedItem_RemovesPropertyChangedEventHandlers()
        //{
        //    var item1 = new Item();
        //    var item2 = new Item();
        //    var bindingList = new CiccioSet<Item> { item1 };
        //    Assert.Equal(1, item1.InvocationList.Length);

        //    bool calledListChanged = false;
        //    bindingList.ListChanged += (object sender, ListChangedEventArgs e) =>
        //    {
        //        calledListChanged = true;
        //        Assert.Equal(ListChangedType.ItemChanged, e.ListChangedType);
        //        Assert.Equal(0, e.NewIndex);
        //    };

        //    bindingList[0] = item2;
        //    Assert.True(calledListChanged);
        //    Assert.Equal(item2, bindingList[0]);
        //    Assert.Null(item1.InvocationList);
        //    Assert.Equal(1, item2.InvocationList.Length);
        //}

        [Fact]
        public void SortProperty_Get_ReturnsNull()
        {
            IBindingList bindingList = new CiccioSet<object>();
            Assert.Null(bindingList.SortProperty);
        }

        [Fact]
        public void ApplySort_Invoke_ThrowsNotSupportedException()
        {
            IBindingList bindingList = new BindingCollection<object>();
            Assert.Throws<NotSupportedException>(() => bindingList.ApplySort(null, ListSortDirection.Descending));
        }

        [Fact]
        public void RemoveSort_Invoke_ThrowsNotSupportedException()
        {
            IBindingList bindingList = new BindingCollection<object>();
            Assert.Throws<NotSupportedException>(() => bindingList.RemoveSort());
        }

        [Fact]
        public void Find_Invoke_ThrowsNotSupportedException()
        {
            IBindingList bindingList = new BindingCollection<object>();
            Assert.Throws<NotSupportedException>(() => bindingList.Find(null, null));
        }

        [Fact]
        public void AddIndex_RemoveIndex_Nop()
        {
            IBindingList bindingList = new BindingCollection<object>();
            bindingList.AddIndex(null);
            bindingList.RemoveIndex(null);
        }

        [Fact]
        public void ItemPropertyChanged_RaiseListChangedEventsFalse_InvokesItemChanged()
        {
            var item = new Item();
            var bindingList = new BindingCollection<Item> { item };

            bool calledListChanged = false;
            bindingList.ListChanged += (object sender, ListChangedEventArgs e) =>
            {
                calledListChanged = true;
                Assert.Equal(ListChangedType.ItemChanged, e.ListChangedType);
                Assert.Equal(0, e.NewIndex);
                Assert.Equal("Name", e.PropertyDescriptor.Name);
                Assert.Equal(typeof(string), e.PropertyDescriptor.PropertyType);
            };

            // Invoke once
            item.Name = "name";
            Assert.True(calledListChanged);

            // Invoke twice.
            calledListChanged = false;
            item.Name = "name2";
            Assert.True(calledListChanged);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("sender")]
        public void ItemPropertyChanged_InvalidSender_InvokesReset(object invokeSender)
        {
            var item = new Item();
            var bindingList = new BindingCollection<Item> { item };

            bool calledListChanged = false;
            bindingList.ListChanged += (object sender, ListChangedEventArgs e) =>
            {
                calledListChanged = true;
                Assert.Equal(ListChangedType.Reset, e.ListChangedType);
                Assert.Equal(-1, e.NewIndex);
            };

            item.InvokePropertyChanged(invokeSender, new PropertyChangedEventArgs("Name"));
            Assert.True(calledListChanged);
        }

        public static IEnumerable<object[]> InvalidEventArgs_TestData()
        {
            yield return new object[] { null };
            yield return new object[] { new PropertyChangedEventArgs(null) };
            yield return new object[] { new PropertyChangedEventArgs(string.Empty) };
        }

        [Theory]
        [MemberData(nameof(InvalidEventArgs_TestData))]
        public void ItemPropertyChanged_InvalidEventArgs_InvokesReset(PropertyChangedEventArgs eventArgs)
        {
            var item = new Item();
            var bindingList = new BindingCollection<Item> { item };

            bool calledListChanged = false;
            bindingList.ListChanged += (object sender, ListChangedEventArgs e) =>
            {
                calledListChanged = true;
                Assert.Equal(ListChangedType.Reset, e.ListChangedType);
                Assert.Equal(-1, e.NewIndex);
            };

            item.InvokePropertyChanged(item, eventArgs);
            Assert.True(calledListChanged);
        }

        [Fact]
        public void InvokePropertyChanged_NoSuchObjectAnymore_InvokesReset()
        {
            var item1 = new Item();
            var item2 = new Item();
            var bindingList = new BindingCollection<Item> { item1 };

            bool calledListChanged = false;
            bindingList.ListChanged += (object sender, ListChangedEventArgs e) =>
            {
                calledListChanged = true;
                Assert.Equal(ListChangedType.Reset, e.ListChangedType);
                Assert.Equal(-1, e.NewIndex);
            };

            item1.InvokePropertyChanged(item2, new PropertyChangedEventArgs("Name"));
            Assert.True(calledListChanged);
        }

        private class Item : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            private string _name;
            public string Name
            {
                get => _name;
                set
                {
                    if (_name != value)
                    {
                        _name = value;
                        OnPropertyChanged();
                    }
                }
            }

            public Delegate[] InvocationList => PropertyChanged?.GetInvocationList();

            public void InvokePropertyChanged(object sender, PropertyChangedEventArgs e)
            {
                PropertyChanged?.Invoke(sender, e);
            }

            private void OnPropertyChanged()
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        [Fact]
        public void Insert_Null_Success()
        {
            var list = new BindingCollection<Item>();
            list.Insert(0, null);

            Assert.Equal(1, list.Count);
        }
    }
}
