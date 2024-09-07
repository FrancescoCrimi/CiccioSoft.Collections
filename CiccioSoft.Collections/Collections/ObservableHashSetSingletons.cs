// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.ComponentModel;

namespace CiccioSoft.Collections;

internal static class ObservableHashSetSingletons
{
    public static readonly PropertyChangedEventArgs CountPropertyChanged = new("Count");
    public static readonly PropertyChangingEventArgs CountPropertyChanging = new("Count");

    public static readonly object[] NoItems = Array.Empty<object>();
}
