namespace code_challenges.Task01;

using System;
using System.Collections.Generic;


public class Point2D
{
    public int x;
    public int y;

    public Point2D(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class Solution
{
    readonly Point2D origin = new Point2D(0, 0);

    public int solution(Point2D[] points)
    {
        int distinctLines = 0;
        HashSet<Point2D> processedPoints = new HashSet<Point2D>();

        foreach (Point2D point1 in points)
        {
            if (point1.x == 0 && point1.y == 0)
            {
                continue;
            }

            if (!processedPoints.Contains(point1))
            {
                distinctLines++;
                processedPoints.Add(point1);

                foreach (Point2D point2 in points)
                {
                    if (!processedPoints.Contains(point2) && IsPointOnLine(origin, point1, point2))
                    {
                        processedPoints.Add(point2);
                    }
                }
            }
        }

        return distinctLines;
    }


    private bool IsPointOnLine(Point2D point1, Point2D point2, Point2D point3)
    {
        var area = (point2.x - point1.x) * (point3.y - point1.y) - (point3.x - point1.x) * (point2.y - point1.y);
        return Math.Abs(area) <= 1e-6;
    }
}
