``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1826 (21H2)
Intel Xeon CPU X3440 2.53GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|              Method |         Mean |      Error |     StdDev | Rank |  Gen 0 | Allocated |
|-------------------- |-------------:|-----------:|-----------:|-----:|-------:|----------:|
|       TestQuickSort |    97.729 μs |  1.4973 μs |  1.3273 μs |    3 | 0.8545 |      4 KB |
|      TestBubbleSort | 1,930.250 μs | 32.0194 μs | 29.9510 μs |    6 |      - |      4 KB |
|   TestSelectionSort |   524.283 μs | 10.0730 μs | 13.0977 μs |    4 |      - |      4 KB |
|    TestCountingSort |     5.611 μs |  0.1073 μs |  0.0896 μs |    1 | 0.9766 |      4 KB |
|      TestShakerSort | 1,501.490 μs | 29.5146 μs | 31.5803 μs |    5 |      - |      4 KB |
| TestQuickDotnetSort |    23.199 μs |  0.2951 μs |  0.2616 μs |    2 | 0.9460 |      4 KB |
