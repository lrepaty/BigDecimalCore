# Introduction
An arbitrary precision decimal (base 10) floating point number type using a mantissa and exponent. Supports logarithms, Exp, Pi, trigonometric functions, etc.

# Getting started
## Prerequisites
dotnet 8.0

## Installation
You can install it with the Package Manager in your IDE or alternatively using the command line:

```bash
dotnet add package BigDecimalCore
```
## Usage

```csharp
decimal dValue = 1;
BigDecimal.Precision = 500;
BigDecimal bigDecimalResult = BigDecimal.Exp(dValue);
```
