# CiccioSoft.Collections


Author: Francesco Crimi <br>
License: MIT <br>
[![Nuget](https://img.shields.io/nuget/v/CiccioSoft.Collections)](https://www.nuget.org/packages/CiccioSoft.Collections/) <br>

This library contains generic IList and ISet implementations that implement INotifyCollectionChanged and IBindinList interface, see below


### `CiccioList<T>`
  implement `IList<T>, IBindinList, IRaiseItemChangedEvents, INotifyCollectionChanged, INotifyPropertyChanged, IReadOnlyList<T>` to use with WinForms, WPF and UWP.

### `CiccioSet<T>`
  implement `ISet<T>, IBindinList, IRaiseItemChangedEvents, INotifyCollectionChanged, INotifyPropertyChanged, IReadOnlyCollection<T>` to use with WinForm, WPF and UWP.


### `ObservableList<T>`
  implement `IList<T>, INotifyCollectionChanged, INotifyPropertyChanged, IReadOnlyList<T>` (like `System.Collections.ObjectModel.ObservableCollection<T>`) to use with WPF or UWP.

### `ObservableSet<T>`
  implement `ISet<T>, INotifyCollectionChanged, INotifyPropertyChanged, IReadOnlyCollection<T>` to use with WPF or UWP.


### `BindingCollection<T>`
  implement `IList<T>, IBindinList, IRaiseItemChangedEvents, IReadOnlyList<T>` (like `System.ComponentModel.BindingList<T>` but too light) to use with WinForms.
  
### `BindingSet<T>`
  implement `ISet<T>, IBindinList, IRaiseItemChangedEvents, IReadOnlyCollection<T>` to use with WinForms.
