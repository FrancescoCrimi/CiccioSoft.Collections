// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace CiccioSoft.Collections.Tests.List
{
    /// <summary>
    /// Contains tests that ensure the correctness of the List class.
    /// </summary>
    public class List_Generic_Tests_Insert
    {
        internal class Driver<T>
        {
            #region Insert

            public void BasicInsert(T[] items, T item, int index, int repeat)
            {
                Core.List<T> list = new Core.List<T>(items);

                for (int i = 0; i < repeat; i++)
                {
                    list.Insert(index, item);
                }

                Assert.True(list.Contains(item)); //"Expect it to contain the item."
                Assert.Equal(list.Count, items.Length + repeat); //"Expect to be the same."


                for (int i = 0; i < index; i++)
                {
                    Assert.Equal(list[i], items[i]); //"Expect to be the same."
                }

                for (int i = index; i < index + repeat; i++)
                {
                    Assert.Equal(list[i], item); //"Expect to be the same."
                }


                for (int i = index + repeat; i < list.Count; i++)
                {
                    Assert.Equal(list[i], items[i - repeat]); //"Expect to be the same."
                }
            }

            public void InsertValidations(T[] items)
            {
                Core.List<T> list = new Core.List<T>(items);
                int[] bad = new int[] { items.Length + 1, items.Length + 2, int.MaxValue, -1, -2, int.MinValue };
                for (int i = 0; i < bad.Length; i++)
                {
                    Assert.Throws<ArgumentOutOfRangeException>(() => list.Insert(bad[i], items[0])); //"ArgumentOutOfRangeException expected."
                }
            }

            public void NonGenericIListBasicInsert(T[] items, T item, int index, int repeat)
            {
                Core.List<T> list = new Core.List<T>(items);
                IList _ilist = list;

                for (int i = 0; i < repeat; i++)
                {
                    _ilist.Insert(index, item);
                }

                Assert.True(list.Contains(item)); //"Expected it to be true."
                Assert.Equal(list.Count, items.Length + repeat); //"Expected them to be equal."

                for (int i = 0; i < index; i++)
                {
                    Assert.Equal(list[i], items[i]); //"Expected them to be equal."
                }

                for (int i = index; i < index + repeat; i++)
                {
                    Assert.Equal((object)list[i], item); //"Expected them to be equal."
                }


                for (int i = index + repeat; i < list.Count; i++)
                {
                    Assert.Equal(list[i], items[i - repeat]); //"Expected them to be equal."
                }
            }

            public void NonGenericIListInsertValidations(T[] items)
            {
                Core.List<T> list = new Core.List<T>(items);
                IList _ilist = list;
                int[] bad = new int[] { items.Length + 1, items.Length + 2, int.MaxValue, -1, -2, int.MinValue };
                for (int i = 0; i < bad.Length; i++)
                {
                    Assert.Throws<ArgumentOutOfRangeException>(() => _ilist.Insert(bad[i], items[0])); //"ArgumentOutOfRangeException expected."
                }

                AssertExtensions.Throws<ArgumentException>("value", () => _ilist.Insert(0, new LinkedListNode<string>("blargh"))); //"ArgumentException expected."
            }

            #endregion

            #region Contains

            public void BasicContains(T[] items)
            {
                Core.List<T> list = new Core.List<T>(items);

                for (int i = 0; i < items.Length; i++)
                {
                    Assert.True(list.Contains(items[i])); //"Should contain item."
                }
            }

            public void NonExistingValues(T[] itemsX, T[] itemsY)
            {
                Core.List<T> list = new Core.List<T>(itemsX);

                for (int i = 0; i < itemsY.Length; i++)
                {
                    Assert.False(list.Contains(itemsY[i])); //"Should not contain item"
                }
            }

            public void RemovedValues(T[] items)
            {
                Core.List<T> list = new Core.List<T>(items);
                for (int i = 0; i < items.Length; i++)
                {
                    list.Remove(items[i]);
                    Assert.False(list.Contains(items[i])); //"Should not contain item"
                }
            }

            public void AddRemoveValues(T[] items)
            {
                Core.List<T> list = new Core.List<T>(items);
                for (int i = 0; i < items.Length; i++)
                {
                    list.Add(items[i]);
                    list.Remove(items[i]);
                    list.Add(items[i]);
                    Assert.True(list.Contains(items[i])); //"Should contain item."
                }
            }

            public void MultipleValues(T[] items, int times)
            {
                Core.List<T> list = new Core.List<T>(items);

                for (int i = 0; i < times; i++)
                {
                    list.Add(items[items.Length / 2]);
                }

                for (int i = 0; i < times + 1; i++)
                {
                    Assert.True(list.Contains(items[items.Length / 2])); //"Should contain item."
                    list.Remove(items[items.Length / 2]);
                }
                Assert.False(list.Contains(items[items.Length / 2])); //"Should not contain item"
            }
            public void ContainsNullWhenReference(T[] items, T value)
            {
                if ((object)value != null)
                {
                    throw new ArgumentException("invalid argument passed to testcase");
                }

                Core.List<T> list = new Core.List<T>(items);
                list.Add(value);
                Assert.True(list.Contains(value)); //"Should contain item."
            }

            public void NonGenericIListBasicContains(T[] items)
            {
                Core.List<T> list = new Core.List<T>(items);
                IList _ilist = list;

                for (int i = 0; i < items.Length; i++)
                {
                    Assert.True(_ilist.Contains(items[i])); //"Should contain item."
                }
            }

            public void NonGenericIListNonExistingValues(T[] itemsX, T[] itemsY)
            {
                Core.List<T> list = new Core.List<T>(itemsX);
                IList _ilist = list;

                for (int i = 0; i < itemsY.Length; i++)
                {
                    Assert.False(_ilist.Contains(itemsY[i])); //"Should not contain item"
                }
            }

            public void NonGenericIListRemovedValues(T[] items)
            {
                Core.List<T> list = new Core.List<T>(items);
                IList _ilist = list;
                for (int i = 0; i < items.Length; i++)
                {
                    list.Remove(items[i]);
                    Assert.False(_ilist.Contains(items[i])); //"Should not contain item"
                }
            }

            public void NonGenericIListAddRemoveValues(T[] items)
            {
                Core.List<T> list = new Core.List<T>(items);
                IList _ilist = list;
                for (int i = 0; i < items.Length; i++)
                {
                    list.Add(items[i]);
                    list.Remove(items[i]);
                    list.Add(items[i]);
                    Assert.True(_ilist.Contains(items[i])); //"Should contain item."
                }
            }

            public void NonGenericIListMultipleValues(T[] items, int times)
            {
                Core.List<T> list = new Core.List<T>(items);
                IList _ilist = list;

                for (int i = 0; i < times; i++)
                {
                    list.Add(items[items.Length / 2]);
                }

                for (int i = 0; i < times + 1; i++)
                {
                    Assert.True(_ilist.Contains(items[items.Length / 2])); //"Should contain item."
                    list.Remove(items[items.Length / 2]);
                }
                Assert.False(_ilist.Contains(items[items.Length / 2])); //"Should not contain item"
            }

            public void NonGenericIListContainsNullWhenReference(T[] items, T value)
            {
                if ((object)value != null)
                {
                    throw new ArgumentException("invalid argument passed to testcase");
                }

                Core.List<T> list = new Core.List<T>(items);
                IList _ilist = list;
                list.Add(value);
                Assert.True(_ilist.Contains(value)); //"Should contain item."
            }

            public void NonGenericIListContainsTestParams()
            {
                Core.List<T> list = new Core.List<T>();
                IList _ilist = list;

                Assert.False(_ilist.Contains(new LinkedListNode<string>("rah")),
                    "Err_68850ahiuedpz Expected Contains to return false with invalid type");
            }

            #endregion

            #region Clear

            public void ClearEmptyList()
            {
                Core.List<T> list = new Core.List<T>();
                Assert.Equal(0, list.Count); //"Should be equal to 0"
                list.Clear();
                Assert.Equal(0, list.Count); //"Should be equal to 0."
            }
            public void ClearMultipleTimesEmptyList(int times)
            {
                Core.List<T> list = new Core.List<T>();
                Assert.Equal(0, list.Count); //"Should be equal to 0."
                for (int i = 0; i < times; i++)
                {
                    list.Clear();
                    Assert.Equal(0, list.Count); //"Should be equal to 0."
                }
            }
            public void ClearNonEmptyList(T[] items)
            {
                Core.List<T> list = new Core.List<T>(items);
                list.Clear();
                Assert.Equal(0, list.Count); //"Should be equal to 0."
            }

            public void ClearMultipleTimesNonEmptyList(T[] items, int times)
            {
                Core.List<T> list = new Core.List<T>(items);
                for (int i = 0; i < times; i++)
                {
                    list.Clear();
                    Assert.Equal(0, list.Count); //"Should be equal to 0."
                }
            }

            public void NonGenericIListClearEmptyList()
            {
                Core.List<T> list = new Core.List<T>();
                IList _ilist = list;
                Assert.Equal(0, list.Count); //"Should be equal to 0."
                _ilist.Clear();
                Assert.Equal(0, list.Count); //"Should be equal to 0."
            }
            public void NonGenericIListClearMultipleTimesEmptyList(int times)
            {
                Core.List<T> list = new Core.List<T>();
                IList _ilist = list;
                Assert.Equal(0, list.Count); //"Should be equal to 0."
                for (int i = 0; i < times; i++)
                {
                    _ilist.Clear();
                    Assert.Equal(0, list.Count); //"Should be equal to 0."
                }
            }
            public void NonGenericIListClearNonEmptyList(T[] items)
            {
                Core.List<T> list = new Core.List<T>(items);
                IList _ilist = list;
                _ilist.Clear();
                Assert.Equal(0, list.Count); //"Should be equal to 0."
            }

            public void NonGenericIListClearMultipleTimesNonEmptyList(T[] items, int times)
            {
                Core.List<T> list = new Core.List<T>(items);
                IList _ilist = list;
                for (int i = 0; i < times; i++)
                {
                    _ilist.Clear();
                    Assert.Equal(0, list.Count); //"Should be equal to 0."
                }
            }

            #endregion
        }

        [Fact]
        public static void InsertTests()
        {
            Driver<int> IntDriver = new Driver<int>();
            int[] intArr1 = new int[100];
            for (int i = 0; i < 100; i++)
                intArr1[i] = i;

            int[] intArr2 = new int[100];
            for (int i = 0; i < 100; i++)
                intArr2[i] = i + 100;

            IntDriver.BasicInsert(new int[0], 1, 0, 3);
            IntDriver.BasicInsert(intArr1, 101, 50, 4);
            IntDriver.BasicInsert(intArr1, 100, 100, 5);
            IntDriver.BasicInsert(intArr1, 100, 99, 6);
            IntDriver.BasicInsert(intArr1, 50, 0, 7);
            IntDriver.BasicInsert(intArr1, 50, 1, 8);
            IntDriver.BasicInsert(intArr1, 100, 50, 50);

            IntDriver.NonGenericIListBasicInsert(new int[0], 1, 0, 3);
            IntDriver.NonGenericIListBasicInsert(intArr1, 101, 50, 4);
            IntDriver.NonGenericIListBasicInsert(intArr1, 100, 100, 5);
            IntDriver.NonGenericIListBasicInsert(intArr1, 100, 99, 6);
            IntDriver.NonGenericIListBasicInsert(intArr1, 50, 0, 7);
            IntDriver.NonGenericIListBasicInsert(intArr1, 50, 1, 8);
            IntDriver.NonGenericIListBasicInsert(intArr1, 100, 50, 50);

            Driver<string> StringDriver = new Driver<string>();
            string[] stringArr1 = new string[100];
            for (int i = 0; i < 100; i++)
                stringArr1[i] = "SomeTestString" + i.ToString();
            string[] stringArr2 = new string[100];
            for (int i = 0; i < 100; i++)
                stringArr2[i] = "SomeTestString" + (i + 100).ToString();

            StringDriver.BasicInsert(stringArr1, "strobia", 99, 2);
            StringDriver.BasicInsert(stringArr1, "strobia", 100, 3);
            StringDriver.BasicInsert(stringArr1, "strobia", 0, 4);
            StringDriver.BasicInsert(stringArr1, "strobia", 1, 5);
            StringDriver.BasicInsert(stringArr1, "strobia", 50, 51);
            StringDriver.BasicInsert(stringArr1, "strobia", 0, 100);
            StringDriver.BasicInsert(new string[] { null, null, null, "strobia", null }, null, 2, 3);
            StringDriver.BasicInsert(new string[] { null, null, null, null, null }, "strobia", 0, 5);
            StringDriver.BasicInsert(new string[] { null, null, null, null, null }, "strobia", 5, 1);
            StringDriver.NonGenericIListBasicInsert(stringArr1, "strobia", 99, 2);
            StringDriver.NonGenericIListBasicInsert(stringArr1, "strobia", 100, 3);
            StringDriver.NonGenericIListBasicInsert(stringArr1, "strobia", 0, 4);
            StringDriver.NonGenericIListBasicInsert(stringArr1, "strobia", 1, 5);
            StringDriver.NonGenericIListBasicInsert(stringArr1, "strobia", 50, 51);
            StringDriver.NonGenericIListBasicInsert(stringArr1, "strobia", 0, 100);
            StringDriver.NonGenericIListBasicInsert(new string[] { null, null, null, "strobia", null }, null, 2, 3);
            StringDriver.NonGenericIListBasicInsert(new string[] { null, null, null, null, null }, "strobia", 0, 5);
            StringDriver.NonGenericIListBasicInsert(new string[] { null, null, null, null, null }, "strobia", 5, 1);
        }

        [Fact]
        public static void InsertTests_negative()
        {
            Driver<int> IntDriver = new Driver<int>();
            int[] intArr1 = new int[100];
            for (int i = 0; i < 100; i++)
                intArr1[i] = i;
            IntDriver.InsertValidations(intArr1);
            IntDriver.NonGenericIListInsertValidations(intArr1);

            Driver<string> StringDriver = new Driver<string>();
            string[] stringArr1 = new string[100];
            for (int i = 0; i < 100; i++)
                stringArr1[i] = "SomeTestString" + i.ToString();
            StringDriver.InsertValidations(stringArr1);
            StringDriver.NonGenericIListInsertValidations(stringArr1);
        }

        [Fact]
        public static void ContainsTests()
        {
            Driver<int> IntDriver = new Driver<int>();
            int[] intArr1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                intArr1[i] = i;
            }

            int[] intArr2 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                intArr2[i] = i + 10;
            }

            IntDriver.BasicContains(intArr1);
            IntDriver.NonExistingValues(intArr1, intArr2);
            IntDriver.RemovedValues(intArr1);
            IntDriver.AddRemoveValues(intArr1);
            IntDriver.MultipleValues(intArr1, 3);
            IntDriver.MultipleValues(intArr1, 5);
            IntDriver.MultipleValues(intArr1, 17);
            IntDriver.NonGenericIListBasicContains(intArr1);
            IntDriver.NonGenericIListNonExistingValues(intArr1, intArr2);
            IntDriver.NonGenericIListRemovedValues(intArr1);
            IntDriver.NonGenericIListAddRemoveValues(intArr1);
            IntDriver.NonGenericIListMultipleValues(intArr1, 3);
            IntDriver.NonGenericIListMultipleValues(intArr1, 5);
            IntDriver.NonGenericIListMultipleValues(intArr1, 17);
            IntDriver.NonGenericIListContainsTestParams();


            Driver<string> StringDriver = new Driver<string>();
            string[] stringArr1 = new string[10];
            for (int i = 0; i < 10; i++)
            {
                stringArr1[i] = "SomeTestString" + i.ToString();
            }
            string[] stringArr2 = new string[10];
            for (int i = 0; i < 10; i++)
            {
                stringArr2[i] = "SomeTestString" + (i + 10).ToString();
            }

            StringDriver.BasicContains(stringArr1);
            StringDriver.NonExistingValues(stringArr1, stringArr2);
            StringDriver.RemovedValues(stringArr1);
            StringDriver.AddRemoveValues(stringArr1);
            StringDriver.MultipleValues(stringArr1, 3);
            StringDriver.MultipleValues(stringArr1, 5);
            StringDriver.MultipleValues(stringArr1, 17);
            StringDriver.ContainsNullWhenReference(stringArr1, null);
            StringDriver.NonGenericIListBasicContains(stringArr1);
            StringDriver.NonGenericIListNonExistingValues(stringArr1, stringArr2);
            StringDriver.NonGenericIListRemovedValues(stringArr1);
            StringDriver.NonGenericIListAddRemoveValues(stringArr1);
            StringDriver.NonGenericIListMultipleValues(stringArr1, 3);
            StringDriver.NonGenericIListMultipleValues(stringArr1, 5);
            StringDriver.NonGenericIListMultipleValues(stringArr1, 17);
            StringDriver.NonGenericIListContainsNullWhenReference(stringArr1, null);
            StringDriver.NonGenericIListContainsTestParams();
        }

        [Fact]
        public static void ClearTests()
        {
            Driver<int> IntDriver = new Driver<int>();
            int[] intArr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                intArr[i] = i;
            }

            IntDriver.ClearEmptyList();
            IntDriver.ClearMultipleTimesEmptyList(1);
            IntDriver.ClearMultipleTimesEmptyList(10);
            IntDriver.ClearMultipleTimesEmptyList(100);
            IntDriver.ClearNonEmptyList(intArr);
            IntDriver.ClearMultipleTimesNonEmptyList(intArr, 2);
            IntDriver.ClearMultipleTimesNonEmptyList(intArr, 7);
            IntDriver.ClearMultipleTimesNonEmptyList(intArr, 31);
            IntDriver.NonGenericIListClearEmptyList();
            IntDriver.NonGenericIListClearMultipleTimesEmptyList(1);
            IntDriver.NonGenericIListClearMultipleTimesEmptyList(10);
            IntDriver.NonGenericIListClearMultipleTimesEmptyList(100);
            IntDriver.NonGenericIListClearNonEmptyList(intArr);
            IntDriver.NonGenericIListClearMultipleTimesNonEmptyList(intArr, 2);
            IntDriver.NonGenericIListClearMultipleTimesNonEmptyList(intArr, 7);
            IntDriver.NonGenericIListClearMultipleTimesNonEmptyList(intArr, 31);

            Driver<string> StringDriver = new Driver<string>();
            string[] stringArr = new string[10];
            for (int i = 0; i < 10; i++)
            {
                stringArr[i] = "SomeTestString" + i.ToString();
            }

            StringDriver.ClearEmptyList();
            StringDriver.ClearMultipleTimesEmptyList(1);
            StringDriver.ClearMultipleTimesEmptyList(10);
            StringDriver.ClearMultipleTimesEmptyList(100);
            StringDriver.ClearNonEmptyList(stringArr);
            StringDriver.ClearMultipleTimesNonEmptyList(stringArr, 2);
            StringDriver.ClearMultipleTimesNonEmptyList(stringArr, 7);
            StringDriver.ClearMultipleTimesNonEmptyList(stringArr, 31);
            StringDriver.NonGenericIListClearEmptyList();
            StringDriver.NonGenericIListClearMultipleTimesEmptyList(1);
            StringDriver.NonGenericIListClearMultipleTimesEmptyList(10);
            StringDriver.NonGenericIListClearMultipleTimesEmptyList(100);
            StringDriver.NonGenericIListClearNonEmptyList(stringArr);
            StringDriver.NonGenericIListClearMultipleTimesNonEmptyList(stringArr, 2);
            StringDriver.NonGenericIListClearMultipleTimesNonEmptyList(stringArr, 7);
            StringDriver.NonGenericIListClearMultipleTimesNonEmptyList(stringArr, 31);
        }
    }
}
