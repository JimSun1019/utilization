# ExtensionSys - C# Extension Methods Library

A comprehensive C# library containing useful extension methods for common data types to enhance productivity and code readability.

## Features

This library provides extension methods for:
- **String operations** - String manipulation and utility methods
- **DateTime operations** - Date and time utility methods
- **List operations** - Collection manipulation methods (coming soon)

## Installation

### Using .NET CLI
```bash
dotnet build ExtensionSys/ExtensionSys.sln
```

### Using Visual Studio
1. Open `ExtensionSys/ExtensionSys.sln`
2. Build the solution (Ctrl+Shift+B)

## Usage

Add the namespace to your C# file:
```csharp
using ExtensionSys;
```

## Available Extension Methods

### String Extensions

#### Reverse()
```csharp
string text = "Hello";
string reversed = text.Reverse(); // "olleH"
```

#### ToTitleCase()
```csharp
string text = "hello world";
string titleCase = text.ToTitleCase(); // "Hello World"
```

#### Truncate()
```csharp
string text = "This is a long string";
string truncated = text.Truncate(10); // "This is a "
```

### DateTime Extensions

#### IsWeekend() / IsWeekday()
```csharp
DateTime date = new DateTime(2025, 8, 3); // Sunday
bool isWeekend = date.IsWeekend(); // true
bool isWeekday = date.IsWeekday(); // false
```

#### StartOfDay() / EndOfDay()
```csharp
DateTime date = new DateTime(2025, 8, 4, 14, 30, 45);
DateTime startOfDay = date.StartOfDay(); // 2025-08-04 00:00:00
DateTime endOfDay = date.EndOfDay(); // 2025-08-04 23:59:59.9999999
```

#### StartOfMonth() / EndOfMonth()
```csharp
DateTime date = new DateTime(2025, 8, 15);
DateTime startOfMonth = date.StartOfMonth(); // 2025-08-01 00:00:00
DateTime endOfMonth = date.EndOfMonth(); // 2025-08-31 23:59:59.9999999
```

#### StartOfYear() / EndOfYear()
```csharp
DateTime date = new DateTime(2025, 8, 4);
DateTime startOfYear = date.StartOfYear(); // 2025-01-01 00:00:00
DateTime endOfYear = date.EndOfYear(); // 2025-12-31 23:59:59.9999999
```

#### CalculateAge()
```csharp
DateTime birthDate = new DateTime(1990, 5, 15);
int age = birthDate.CalculateAge(); // Calculates age from birth date to today
int ageAtDate = birthDate.CalculateAge(new DateTime(2025, 8, 4)); // Age at specific date
```

## Project Structure

```
ExtensionSys/
├── ExtensionSys.sln           # Solution file
├── Tests.csproj               # Test project
└── ExtensionSys/
    ├── ExtensionSys.csproj    # Main project file
    ├── Program.cs             # Entry point
    ├── StringExtension.cs     # String extension methods
    ├── DateTimeExtension.cs   # DateTime extension methods
    └── ListExtension.cs       # List extension methods (in development)
```

## Development

### Building the Project
```bash
dotnet build ExtensionSys/ExtensionSys.sln
```

### Running the Project
```bash
dotnet run --project ExtensionSys/ExtensionSys/ExtensionSys.csproj
```

### Publishing
```bash
dotnet publish ExtensionSys/ExtensionSys.sln
```

## Contributing

1. Fork the repository
2. Create a feature branch
3. Add your extension methods with appropriate documentation
4. Include unit tests for new methods
5. Submit a pull request

## Requirements

- .NET 8.0 or higher
- Visual Studio 2022 or VS Code with C# extension

## License

This project is open source and available under the MIT License.

## Roadmap

- [ ] Complete List extension methods
- [ ] Add numeric extension methods
- [ ] Add collection extension methods
- [ ] Add unit tests
- [ ] Create NuGet package
- [ ] Add more string manipulation methods
- [ ] Add file/path extension methods

## Support

For questions, issues, or contributions, please open an issue in the repository.