// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace System.Collections.Tests
{
    #region TestClasses

    public sealed class TrackingEqualityComparer<T> : IEqualityComparer<T>
    {
        public int EqualsCalls;
        public int GetHashCodeCalls;

        public bool Equals(T x, T y)
        {
            EqualsCalls++;
            return EqualityComparer<T>.Default.Equals(x, y);
        }

        public int GetHashCode(T obj)
        {
            GetHashCodeCalls++;
            return EqualityComparer<T>.Default.GetHashCode(obj);
        }
    }

    #endregion
}
