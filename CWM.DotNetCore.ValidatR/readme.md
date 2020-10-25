## Installation

`Install-Package CWM.DotNetCore.ValidatR`

Or Grab the package from NuGet [here](https://www.nuget.org/packages/CWM.DotNetCore.ValidatR/).

## Features

### ValidatR 

Validates your C# Objects and Throws the Required Exception. Saves you 3 lines of Code everytime. Provides a cleaner way to standardize code.

#### Usage
```c#
using CWM.DotNetCore.ValidatR;
```

```c#
Throw.Exception.IfNull(name, nameof(name));
```

This Replaces the standard Null Check

```c#
if(name == null)
	throw new Exception("Some Message Here");
