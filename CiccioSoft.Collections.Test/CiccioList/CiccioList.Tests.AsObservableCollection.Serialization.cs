// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Tests;
using Xunit;

namespace CiccioSoft.Collections.Tests.CiccioList
{
    public partial class CiccioList_As_ObservableCollection
    {
        public static IEnumerable<object[]> SerializeDeserialize_Roundtrips_MemberData()
        {
            yield return new object[] { new CiccioList<int>() };
            yield return new object[] { new CiccioList<int>() { 42 } };
            yield return new object[] { new CiccioList<int>() { 1, 5, 3, 4, 2 } };
        }

        [ConditionalTheory(typeof(PlatformDetection), nameof(PlatformDetection.IsBinaryFormatterSupported))]
        [MemberData(nameof(SerializeDeserialize_Roundtrips_MemberData))]
        public void SerializeDeserialize_Roundtrips(CiccioList<int> c)
        {
            CiccioList<int> clone = BinaryFormatterHelpers.Clone(c);
            Assert.NotSame(c, clone);
            Assert.Equal(c, clone);
        }

        [Fact]
        [ActiveIssue("https://github.com/dotnet/runtime/issues/57588", typeof(PlatformDetection), nameof(PlatformDetection.IsBuiltWithAggressiveTrimming), nameof(PlatformDetection.IsBrowser))]
        public void OnDeserialized_MonitorNotInitialized_ExpectSuccess()
        {
            var observableCollection = new CiccioList<int>();
            MethodInfo onDeserializedMethodInfo = observableCollection.GetType().GetMethod("OnDeserialized",
                BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            Assert.NotNull(onDeserializedMethodInfo);
            onDeserializedMethodInfo.Invoke(observableCollection, new object[] { null });
        }
    }
}
