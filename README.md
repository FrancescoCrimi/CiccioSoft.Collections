# CiccioSoft.Collections Suite

[![NuGet](https://img.shields.io/nuget/v/CiccioSoft.Collections.svg)](https://www.nuget.org/packages/CiccioSoft.Collections/)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE.TXT)

## Overview

**CiccioSoft.Collections** is a modern, modular suite of advanced generic collections for .NET, designed to support robust data-binding and change notification scenarios across multiple UI technologies.  
Version **8.0.0** introduces a fully modular architecture, with dedicated packages for WinForms, XAML-based UIs (WPF, UWP, WinUI 3), and multi-UI backend scenarios.

The suite targets **.NET 8**, **.NET 6**, **.NET Framework 4.7.2**, and **.NET Standard 2.0**, ensuring maximum compatibility for both modern and legacy applications.

---

## Packages

| Package | Description | Recommended For |
|---------|-------------|----------------|
| [CiccioSoft.Collections](https://www.nuget.org/packages/CiccioSoft.Collections/) | **Metapackage**: Installs all core packages for compatibility with previous versions. | Legacy/transition projects |
| [CiccioSoft.Collections.Binding](https://www.nuget.org/packages/CiccioSoft.Collections.Binding/) | Generic `IBindingList` implementations for `IList<T>` and `ISet<T>`. | WinForms data-binding |
| [CiccioSoft.Collections.Observable](https://www.nuget.org/packages/CiccioSoft.Collections.Observable/) | Observable generic collections implementing `INotifyCollectionChanged` and `INotifyPropertyChanged`. | WPF, UWP, WinUI 3, and other XAML-based UIs |
| [CiccioSoft.Collections.Ciccio](https://www.nuget.org/packages/CiccioSoft.Collections.Ciccio/) | Collections implementing both `IBindingList` and `INotifyCollectionChanged` for multi-UI backends. | Shared backend for WinForms and XAML-based UIs |
| [CiccioSoft.Collections.Core](https://www.nuget.org/packages/CiccioSoft.Collections.Core/) | Core abstractions, utilities, and base classes for custom collections. | Library authors, advanced scenarios |

---

## Key Features

- **Generic IList<T> and ISet<T> implementations** with advanced data-binding and change notification support
- **Observable collections** for MVVM and reactive UI patterns
- **BindingList-like collections** for WinForms
- **Multi-UI backend support**: share collections between WinForms and XAML-based UIs
- **Extensible core** for building your own custom collections
- **Full support for .NET 8, .NET 6, .NET Framework 4.7.2, and .NET Standard 2.0**

---

## Quick Start

### Install the Metapackage (for legacy/compatibility)
`dotnet add package CiccioSoft.Collections`

### Or install only what you need

- **WinForms:**  
  `dotnet add package CiccioSoft.Collections.Binding`
- **WPF/UWP/WinUI 3:**  
  `dotnet add package CiccioSoft.Collections.Observable`
- **Multi-UI backend:**  
  `dotnet add package CiccioSoft.Collections.Ciccio`
- **Core abstractions:**  
  `dotnet add package CiccioSoft.Collections.Core`

---

## Example Usage

### Observable Collection (WPF/UWP/WinUI 3)
```
using CiccioSoft.Collections.Observable;

var observableList = new ObservableList<MyModel>();
observableList.Add(new MyModel { Name = "Item 1" });
observableList.CollectionChanged += (s, e) => { /* React to changes */ };
myItemsControl.ItemsSource = observableList;
```

### Binding Collection (WinForms)
```
using CiccioSoft.Collections.Binding;

var bindingList = new BindingListEx<MyModel>();
bindingList.Add(new MyModel { Name = "Item 1" });
myDataGridView.DataSource = bindingList;
```

### Multi-UI Collection (Backend shared with WinForms and WPF)
```
using CiccioSoft.Collections.Ciccio;

var multiUiList = new MultiUiBindingList<MyModel>(); // Bind to both WinForms and WPF frontends
```

---

## Documentation

- [Project Website](https://francescocrimi.github.io/CiccioSoft.Collections/)
- [API Reference](https://francescocrimi.github.io/CiccioSoft.Collections/api/)
- [Release Notes](https://github.com/FrancescoCrimi/CiccioSoft.Collections/releases)

---

## License

This project is licensed under the [MIT License](LICENSE.TXT).

---

## Author

Francesco Crimi  
[GitHub](https://github.com/FrancescoCrimi)

---

## Contributing

Contributions, issues, and feature requests are welcome!  
Feel free to open an [issue](https://github.com/FrancescoCrimi/CiccioSoft.Collections/issues) or submit a pull request.

---

## Acknowledgements

Inspired by the needs of modern .NET UI development and the desire for flexible, reusable, and robust collection types.


