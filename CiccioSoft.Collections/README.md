# CiccioSoft.Collections

[![NuGet](https://img.shields.io/nuget/vpre/CiccioSoft.Collections.svg)](https://www.nuget.org/packages/CiccioSoft.Collections/)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](../LICENSE.TXT)

## Overview

**CiccioSoft.Collections** is a metapackage for the CiccioSoft.Collections suite.  
It does not contain any code or assemblies, but simply references the following packages:

- [CiccioSoft.Collections.Binding](https://www.nuget.org/packages/CiccioSoft.Collections.Binding/)
- [CiccioSoft.Collections.Observable](https://www.nuget.org/packages/CiccioSoft.Collections.Observable/)
- [CiccioSoft.Collections.Ciccio](https://www.nuget.org/packages/CiccioSoft.Collections.Ciccio/)

This package exists only for compatibility with previous versions.  
When you install CiccioSoft.Collections, you automatically get all the above packages.

> **Note:**  
> For new projects, it is recommended to reference only the specific package(s) you need:
> - Use **CiccioSoft.Collections.Binding** for advanced data-binding in WinForms.
> - Use **CiccioSoft.Collections.Observable** for observable collections in XAML-based UIs (WPF, UWP, WinUI 3).
> - Use **CiccioSoft.Collections.Ciccio** only if you need to share backend logic between WinForms and XAML-based UIs.

## Installation

Install via NuGet Package Manager:

Or via .NET CLI:

## License

This project is licensed under the [MIT License](../LICENSE.TXT).

## Links

- [Project Website](https://francescocrimi.github.io/CiccioSoft.Collections/)
- [GitHub Repository](https://github.com/FrancescoCrimi/CiccioSoft.Collections)
