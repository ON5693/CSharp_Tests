``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1555/22H2/2022Update/SunValley2)
11th Gen Intel Core i5-11400H 2.70GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.302
  [Host]     : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2


```
|           Method |    Size |           Mean |        Error |       StdDev |   Gen0 |   Gen1 | Allocated |
|----------------- |-------- |---------------:|-------------:|-------------:|-------:|-------:|----------:|
|          **ForEach** |     **100** |       **184.0 ns** |      **2.36 ns** |      **4.49 ns** |      **-** |      **-** |         **-** |
| ForEachParalell2 |     100 |     9,208.6 ns |    178.32 ns |    183.12 ns | 1.1444 | 0.0153 |    7152 B |
|          **ForEach** | **1000000** | **1,572,339.5 ns** | **17,638.42 ns** | **16,498.99 ns** |      **-** |      **-** |       **1 B** |
| ForEachParalell2 | 1000000 | 1,221,404.5 ns | 23,780.83 ns | 32,551.47 ns |      - |      - |    7212 B |
