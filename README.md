[![NuGet Version](https://img.shields.io/nuget/v/Drastic.ForbiddenControls.svg)](https://www.nuget.org/packages/Drastic.ForbiddenControls/) ![License](https://img.shields.io/badge/License-MIT-blue.svg)

# Drastic.ForbiddenControls

Drastic.ForbiddenControls an Mac Catalyst library for allowing access to "Forbidden" controls in the Mac Catalyst Desktop Idiom.

## Setup

- Install the Nuget
- Run

```csharp
DrasticForbiddenControls.CatalystControls.AllowsUnsupportedMacIdiomBehavior();
```

This will run underlying Objective-C code, calling for `UIStepper`, `UIPickerView` and `UIRefreshView` to `_setAllowsUnsupportedMacIdiomBehavior` to be true. This will let the controls run within Mac Catalyst with the Desktop Idiom. This is a private API and is very much unsupported: Using this code would most likely have your app blocked in the Mac App Store. That said, it is still useful in cases where controls that UIPickerView would be otherwise unavailable in Mac Catalyst in Desktop mode.