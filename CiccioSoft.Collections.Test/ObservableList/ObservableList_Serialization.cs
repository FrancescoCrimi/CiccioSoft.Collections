// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Tests;
using Xunit;

namespace CiccioSoft.Collections.Generic.Test.ObservableList
{
    public partial class ObservableList_Serialization
    {
        public static IEnumerable<object[]> SerializeDeserialize_Roundtrips_MemberData()
        {
            yield return new object[] { new ObservableList<int>() };
            yield return new object[] { new ObservableList<int>() { 42 } };
            yield return new object[] { new ObservableList<int>() { 1, 5, 3, 4, 2 } };
        }

        [Theory]
        [MemberData(nameof(SerializeDeserialize_Roundtrips_MemberData))]
        public void SerializeDeserialize_Roundtrips(ObservableList<int> c)
        {
            ObservableList<int> clone = BinaryFormatterHelpers.Clone(c);
            Assert.NotSame(c, clone);
            Assert.Equal(c, clone);
        }

        [Fact]
        public void OnDeserialized_MonitorNotInitialized_ExpectSuccess()
        {
            var observableCollection = new ObservableList<int>();
            MethodInfo onDeserializedMethodInfo = observableCollection.GetType().GetMethod("OnDeserialized",
                BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            Assert.NotNull(onDeserializedMethodInfo);
            onDeserializedMethodInfo.Invoke(observableCollection, new object[] { null });
        }
    }
}
