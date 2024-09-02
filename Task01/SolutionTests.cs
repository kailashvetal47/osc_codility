using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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


    [Test(ExpectedResult = 0, Description = "GivenOriginAsInput_ExpectResultZero")]
    public int GivenOriginAsInput_ExpectResultZero ()
    {
        Point2D[] input = {new Point2D(0,0)};
        int result = _task.solution(input);
        return result;
    }

    [Test(ExpectedResult = 3, Description = "01-GivenThreeNonLinearPoints_ExpectResultThree")]
    public int GivenThreeNonLinearPoints_ExpectResultThree ()
    {
        Point2D[] input = [new Point2D(0,1), new Point2D(1,0), new Point2D(1,1)];
        int result = _task.solution(input);
        return result;
    }

    [Test(ExpectedResult = 1, Description = "GivenThreeLinearPoints_ExpectResultOne")]
    public int GivenThreeLinearPoints_ExpectResultOne ()
    {
        Point2D[] input = [new Point2D(1,1), new Point2D(2,2), new Point2D(3,3)];
        int result = _task.solution(input);
        return result;
    }

    [Test(ExpectedResult = 3, Description = "GivenThreeLinearPoints_ExpectResultOne")]
    public int GivenOriginAsSecondPointFourNonLinearPoints_ExpectResultThree ()
    {
        Point2D[] input = [new Point2D(0,1), new Point2D(0,0),  new Point2D(1,0), new Point2D(1,1)];
        int result = _task.solution(input);
        return result;
    }

     [Test(ExpectedResult = 3, Description = "GivenThreeLinearPoints_ExpectResultOne")]
    public int GivenBoundryConditionPoints_InThreeNonLinearPoints_ExpectResultThree ()
    {
        Point2D[] input = [new Point2D(1000000,1), new Point2D(0,0),  new Point2D(1,0), new Point2D(1,1)];
        int result = _task.solution(input);
        return result;
    }

}