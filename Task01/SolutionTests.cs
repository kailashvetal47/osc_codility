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
                yield return new TestCaseData([new Point2D(1,1), new Point2D(2,2), new Point2D(3,3)] ){ ExpectedResult = 0, TestName = "1"} ;
                yield return new TestCaseData([new Point2D(0,0)] ){ ExpectedResult = 0, TestName = "2"} ;
                yield return new TestCaseData([new Point2D(1,1), new Point2D(2,2), new Point2D(3,3), new Point2D(4,4), new Point2D(5,5)] )
                 { ExpectedResult = 0, TestName = "3"} ;
            }
        }
    }




     [TestCaseSource(typeof(SolutionTestData), nameof(SolutionTestData.TestCases))]

    public int GivenValidInput_ShouldGiveExpectedResult(Point2D[] input)
    {
        int result = _task.solution(input);
        return result;
    }

}