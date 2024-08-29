using System;
using NUnit.Framework;

namespace code_challenges.Task01;

[TestFixture]
public class SolutionTests
{

     private Solution _task;

    [SetUp]
    public void Setup()
    {
        _task = new Solution();
    }

    [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 0, TestName = "SimpleTest")]
    [TestCase(new int[] { }, ExpectedResult = 0, TestName = "EmptyArray")]
    [TestCase(new int[] { 42 }, ExpectedResult = 0, TestName = "SingleElementArray")]


    public int GivenValidInput_ShouldGiveExpectedResult(int[] input)
    {
        int result = _task.solution(input);
        return result;
    }

}