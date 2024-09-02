using System;
using NUnit.Framework;

namespace code_challenges.Task02;

[TestFixture]
public class SolutionTests
{

     private Solution _task;

    [SetUp]
    public void Setup()
    {
        _task = new Solution();
    }

    
    // return indices of the points

    [Test(Description = "GivenSimpleTriangle_ExpectResultIndicesOfPoints")]
    public void GivenSimpleTriangle_ExpectResultIndicesOfPoints()
    {
        var expected = new int []{2,1,0};
        var X = new int []{2, 1, 0};
        var Y = new int []{0, 1, 0};
        int[] result = _task.solution(X, Y);
        Assert.That(result, Is.EqualTo(expected));
    
    }

     [Test(Description = "GivenSimpleLineTriangle_ExpectResultAsEmptyArray")]
    public void GivenSimpleLineTriangle_ExpectResultAsEmptyArray()
    {
        var expected = new int []{};
        var X = new int []{2, 1, 0};
        var Y = new int []{0, 0, 0};
        int[] result = _task.solution(X, Y);
        Assert.That(result, Is.EqualTo(expected));
    
    }

}