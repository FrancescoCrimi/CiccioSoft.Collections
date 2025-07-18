// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace CiccioSoft.Collections.Core.Tests
{
    [Serializable]
    public class GenericList<T> : CiccioSoft.Collections.Core.List<T>
    {
        public GenericList()
        {
        }

        public GenericList(IEnumerable<T> collection) : base(collection)
        {
        }

        public GenericList(int capacity) : base(capacity)
        {
        }
    }
}
