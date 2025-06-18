# CiccioSoft.Collections.Ciccio

[![NuGet](https://img.shields.io/nuget/vpre/CiccioSoft.Collections.Ciccio.svg)](https://www.nuget.org/packages/CiccioSoft.Collections.Ciccio/)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](../LICENSE.TXT)

## Overview

**CiccioSoft.Collections.Ciccio** provides generic implementations of `IList<T>` and `ISet<T>` that implement both `IBindingList` and `INotifyCollectionChanged`.  
This unique combination makes the library especially useful for backend logic that needs to interface with multiple UI frontends, such as WinForms and XAML-based frameworks (WPF, UWP, WinUI 3) at the same time.

> **Note:**  
> You should use this library **only** if your backend must support both WinForms and XAML-based UIs concurrently.  
> For all other scenarios, consider using the other libraries in the suite:
> - [CiccioSoft.Collections.Observable](https://www.nuget.org/packages/CiccioSoft.Collections.Observable/) for XAML-based UIs (WPF, UWP, WinUI 3)
> - [CiccioSoft.Collections.Binding](https://www.nuget.org/packages/CiccioSoft.Collections.Binding/) for WinForms

## Features

- Generic collections implementing both `IBindingList` and `INotifyCollectionChanged`
- Designed for backend logic shared across WinForms and XAML-based UI frontends
- Full support for advanced data-binding, change tracking, and UI synchronization
- Compatible with .NET 8, .NET 6, .NET Framework 4.7.2, and .NET Standard 2.0

## Installation

Install via NuGet Package Manager:

## Usage Example
```csharp
using CiccioSoft.Collections.Ciccio;

// Create a collection that supports both WinForms and XAML-based data-binding
var multiUiList = new MultiUiBindingList<MyModel>();
multiUiList.Add(new MyModel { Name = "Item 1" });

// Bind to a WinForms DataGridView
myDataGridView.DataSource = multiUiList;

// Bind to a WPF ItemsControl
myItemsControl.ItemsSource = multiUiList;
```

## When to Use

- When your backend logic must be shared between WinForms and XAML-based UI frontends (WPF, UWP, WinUI 3)
- When you need collections that support both `IBindingList` and `INotifyCollectionChanged` for maximum compatibility

## License

This project is licensed under the [MIT License](../LICENSE.TXT).

## Links

- [Project Website](https://francescocrimi.github.io/CiccioSoft.Collections/)
- [NuGet Package](https://www.nuget.org/packages/CiccioSoft.Collections.Ciccio/)
- [GitHub Repository](https://github.com/FrancescoCrimi/CiccioSoft.Collections)
