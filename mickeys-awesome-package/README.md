# Mickey's Awesome Package

## Overview
Mickey's Awesome Package is a simple C# library that provides basic mathematical operations. The current version is 0.1.0.

## Installation
To install the package, you can use the following command in your project:

```
dotnet add package mickeys-awesome-package --version 0.1.0
```

## Usage
To use the `Calculator` class and its `Add` method, include the namespace in your code:

```csharp
using MickeysAwesomePackage;
```

You can then create an instance of the `Calculator` class and call the `Add` method:

```csharp
Calculator calculator = new Calculator();
int result = calculator.Add(5, 10);
Console.WriteLine(result); // Outputs: 15
```

## Contributing
If you would like to contribute to this project, feel free to submit a pull request or open an issue.

## License
This project is licensed under the MIT License.