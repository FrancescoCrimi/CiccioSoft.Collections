# CiccioSoft.Collections.Binding

[![NuGet](https://img.shields.io/nuget/vpre/CiccioSoft.Collections.Binding.svg)](https://www.nuget.org/packages/CiccioSoft.Collections.Binding/)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](../LICENSE.TXT)

## Overview

**CiccioSoft.Collections.Binding** provides generic implementations of `IBindingList` for `IList<T>` and `ISet<T>`, designed for advanced data-binding scenarios in WinForms and .NET applications.  
These collections are ideal for scenarios where you need change notifications and flexible data-binding support.

## Features

- Generic `IBindingList` implementations for `IList<T>` and `ISet<T>`
- Full support for data-binding in WinForms and other .NET UI frameworks
- Change notifications via `IBindingList` and `INotifyCollectionChanged`
- Designed for .NET 8, .NET 6, .NET Framework 4.7.2, and .NET Standard 2.0

## Installation

Install via NuGet Package Manager:
```
Install-Package CiccioSoft.Collections.Binding
```

Or via .NET CLI:
```
dotnet add package CiccioSoft.Collections.Binding
```

## Usage Example

```csharp
// Create a bindable list of your model
var bindingList = new BindingListEx<MyModel>();

// Add items using standard IList<T> methods
bindingList.Add(new MyModel { Name = "Item 1" });
bindingList.Add(new MyModel { Name = "Item 2" });

// Remove an item
bindingList.RemoveAt(0);

// Bind to a WinForms DataGridView
myDataGridView.DataSource = bindingList;

// Create a bindable set 
var bindingSet = new BindingSet<MyModel>();
bindingSet.Add(new MyModel { Name = "Unique Item" });
```

## When to Use

- When you need advanced data-binding with change notifications in WinForms
- For scenarios requiring generic, observable, and bindable collections
- When you want to use `ISet<T>` or `IList<T>` with full data-binding support

## License

This project is licensed under the [MIT License](../LICENSE.TXT).

## Links

- [Project Website](https://francescocrimi.github.io/CiccioSoft.Collections/)
- [NuGet Package](https://www.nuget.org/packages/CiccioSoft.Collections.Binding/)
- [GitHub Repository](https://github.com/FrancescoCrimi/CiccioSoft.Collections)
