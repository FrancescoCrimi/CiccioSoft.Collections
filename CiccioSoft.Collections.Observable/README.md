# CiccioSoft.Collections.Observable

[![NuGet](https://img.shields.io/nuget/vpre/CiccioSoft.Collections.Observable.svg)](https://www.nuget.org/packages/CiccioSoft.Collections.Observable/)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](../LICENSE.TXT)

## Overview

**CiccioSoft.Collections.Observable** provides observable generic implementations of `IList<T>` and `ISet<T>`, supporting automatic change notifications via `INotifyCollectionChanged` and `INotifyPropertyChanged`.  
These collections are ideal for data-binding scenarios in .NET applications, including WinForms, WPF, UWP, and WinUI 3.

> **Note:**  
> WinForms supports data-binding with `INotifyCollectionChanged` (e.g., `ObservableCollection<T>`) starting from **.NET 7**.  
> This enables modern MVVM patterns and reactive UI updates in WinForms, similar to WPF and other XAML-based frameworks.

## Features

- Observable generic collections: `ObservableList<T>`, `ObservableHashSet<T>`
- Implements `INotifyCollectionChanged` and `INotifyPropertyChanged`
- Seamless integration with data-binding in .NET UI frameworks
- Designed for .NET 8, .NET 6, .NET Framework 4.7.2, and .NET Standard 2.0

## Installation

Install via NuGet Package Manager:

Or via .NET CLI:

## Usage Example
```csharp
using CiccioSoft.Collections.Observable;

// Create an observable list
var observableList = new ObservableList<MyModel>();
observableList.Add(new MyModel { Name = "Item 1" });
observableList.Add(new MyModel { Name = "Item 2" });

// Subscribe to collection changed events
observableList.CollectionChanged += (sender, e) => { Console.WriteLine($"Collection changed: {e.Action}"); };

// Bind to a WPF ItemsControl or WinForms DataGridView
myItemsControl.ItemsSource = observableList;
```

## When to Use

- When you need collections that notify UI or other components about changes
- For advanced data-binding scenarios in WinForms, WPF, UWP, or WinUI 3
- When you want to track changes in generic lists or sets

## License

This project is licensed under the [MIT License](../LICENSE.TXT).

## Links

- [Project Website](https://francescocrimi.github.io/CiccioSoft.Collections/)
- [NuGet Package](https://www.nuget.org/packages/CiccioSoft.Collections.Observable/)
- [GitHub Repository](https://github.com/FrancescoCrimi/CiccioSoft.Collections)
