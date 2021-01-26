``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.746 (2004/?/20H1)
AMD Ryzen 5 3600, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|                          Method |      Mean |     Error |    StdDev |    Median |
|-------------------------------- |----------:|----------:|----------:|----------:|
|         DifferenceTwoPointClass | 5.2087 ns | 0.0215 ns | 0.0191 ns | 5.2117 ns |
|        DifferenceTwoPointStruct | 0.0023 ns | 0.0036 ns | 0.0030 ns | 0.0000 ns |
|  DifferenceTwoPointStructDouble | 0.0061 ns | 0.0096 ns | 0.0090 ns | 0.0001 ns |
| DifferenceTwoPointStructNotSqrt | 0.0057 ns | 0.0061 ns | 0.0057 ns | 0.0051 ns |
