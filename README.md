# BenchmarkAnyVsCount

// * Summary *

BenchmarkDotNet v0.13.10, Windows 10 (10.0.19045.3570/22H2/2022Update)
Intel Core i7-4770 CPU 3.40GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100-preview.4.23260.5
  [Host]     : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2


| Method             | Mean      | Error     | StdDev    | Ratio    | RatioSD  | Rank | Allocated | Alloc Ratio |
|------------------- |----------:|----------:|----------:|---------:|---------:|-----:|----------:|------------:|
| ListByCount        | 0.0161 ns | 0.0136 ns | 0.0120 ns |     1.00 |     0.00 |    1 |         - |          NA |
| ListByAny          | 4.9982 ns | 0.0632 ns | 0.0528 ns |   709.26 |   725.76 |    2 |         - |          NA |
| IEnumerableByCount | 9.5427 ns | 0.1176 ns | 0.0982 ns | 1,349.52 | 1,375.27 |    3 |         - |          NA |
| IEnumerableByAny   | 9.7731 ns | 0.1118 ns | 0.0934 ns | 1,386.10 | 1,410.72 |    4 |         - |          NA |
