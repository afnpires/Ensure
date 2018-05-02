# Ensure

A library of extension methods to validate arguments.

## Installation

Please follow the instruction presented [here](https://www.nuget.org/packages/afnpires.Ensure/).

## Usage

```c#

// String
string.Empty.EnsureNotNullOrEmpty(); // Throws ArgumentNullException

// Object

object aObject = null;
aObject.EnsureNotNull(); // Throws ArgumentNullException

aObject.Ensure(o => false /* A condition */, "A error message"); // Throws ArgumentException
```

For a detailed usage overview please see the tests.

## Contribution

Feel free to open Pull Requests with features or open any issue with feature request or bug.