``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.746 (2004/?/20H1)
AMD Ryzen 5 3600, 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4300.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4300.0), X86 LegacyJIT


```
|                         Method |     Mean |     Error |    StdDev |
|------------------------------- |---------:|----------:|----------:|
|        DifferenceTwoPointClass | 5.209 ns | 0.0257 ns | 0.0201 ns |
|       DifferenceTwoPointStruct | 1.466 ns | 0.0070 ns | 0.0066 ns |
| DifferenceTwoPointStructDouble | 2.456 ns | 0.0034 ns | 0.0032 ns |
