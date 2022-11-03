using Xunit;
using Src;
using System.Collections.Generic;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        int n = 2;
        var queries = new List<List<int>>(){new List<int> { 1, 0, 5 },
                                            new List<int> { 1, 1, 7 },
                                            new List<int> { 1, 0, 3 },
                                            new List<int> { 2, 1, 0 },
                                            new List<int> { 2, 1, 1 }};

        var expected = new List<int>() { 7, 3 };
        var actual = Result.dynamicArray(n, queries);

        Assert.Equal(expected, actual);
    }
}