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

    public class SolutionTestData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData([new Point2D(1,1), new Point2D(2,2), new Point2D(3,3)] ){ ExpectedResult = 1, TestName = "Points on same line"} ;
                yield return new TestCaseData([new Point2D(0,1), new Point2D(1,0), new Point2D(1,1)] ){ ExpectedResult = 3, TestName = "Three different points"} ;
                yield return new TestCaseData(new Point2D[] {new Point2D(0,0)} ){ ExpectedResult = 0, TestName = "Origins to origin ray"} ;
                yield return new TestCaseData([new Point2D(1,1), new Point2D(2,2), new Point2D(3,3), new Point2D(4,4), new Point2D(5,5)] )
                 { ExpectedResult = 1, TestName = "Points on same line"} ;
            }
        }
    }


    [Test(ExpectedResult = 0, Description = "GivenOrigin Test")]
    public int GivenOriginAsInput_TestShouldReturnZero ()
    {
        Point2D[] input = {new Point2D(0,0)};
        int result = _task.solution(input);
        return result;
    }

    [Test(ExpectedResult = 3, Description = "Three non linear points")]
    public int GivenThreeNonLinearPoints_ExpectResultThree ()
    {
        Point2D[] input = [new Point2D(0,1), new Point2D(1,0), new Point2D(1,1)];
        int result = _task.solution(input);
        return result;
    }

    [Test(ExpectedResult = 1, Description = "Three linear points")]
    public int GivenThreeLinearPoints_ExpectResultOne ()
    {
        Point2D[] input = [new Point2D(1,1), new Point2D(2,2), new Point2D(3,3)];
        int result = _task.solution(input);
        return result;
    }

}