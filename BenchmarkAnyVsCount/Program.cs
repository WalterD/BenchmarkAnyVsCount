using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;

// How to run the tests:
// In the Solution Explorer, right click on the project name and then "Open Folder in File Explorer"
// Click on the address bar and then press Home to go to the beginning of the line
// Type cmd or Powershell, and a space
// Press enter to open CMD or Power Shell window.
// In command window execute: dotnet build -c release
// After you get a message of a successful build, copy the path to the dll that is displayed
// To run the benchmark, in the command window execute: dotnet [paste the path]
// Benchmark website: https://benchmarkdotnet.org/

BenchmarkRunner.Run<ReversingStringsBenchmarks>();


/// <summary>
/// Test methods to reverse a string.
/// </summary>
[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class ReversingStringsBenchmarks
{
    // Service containing test methods.
    private static readonly TestService testService = new();

    [Benchmark(Baseline = true)]
    public void ListByCount()
    {
        _ = testService.HasItemsInListByCountProperty();
    }

    [Benchmark]
    public void ListByAny()
    {
        _ = testService.HasItemsInListByAny();
    }

    [Benchmark]
    public void IEnumerableByCount()
    {
        _ = testService.HasItemsInIEnumerableByCountProperty();
    }

    [Benchmark]
    public void IEnumerableByAny()
    {
        _ = testService.HasItemsInIEnumerableByAny();
    }
}

public class TestService
{
    public TestService()
    {
        enumerableCollection = Enumerable.Repeat(1, 100);
        listCollection = enumerableCollection.ToList();
    }

    List<int> listCollection;
    IEnumerable<int> enumerableCollection;

    public bool HasItemsInListByCountProperty()
    {
        return listCollection.Count > 0;
    }

    public bool HasItemsInListByAny()
    {
        return listCollection.Any();
    }
    public bool HasItemsInIEnumerableByCountProperty()
    {
        return enumerableCollection.Count() > 0;
    }

    public bool HasItemsInIEnumerableByAny()
    {
        return enumerableCollection.Any();
    }
}