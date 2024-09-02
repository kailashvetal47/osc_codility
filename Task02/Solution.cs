using System;
using System.Collections.Generic;

namespace code_challenges.Task02;

public class Point2D
{
    public int index;
    public int x;
    public int y;

    public Point2D(int index, int x, int y)
    {
        this.index = index;
        this.x = x;
        this.y = y;
    }
}

public class Solution 
{
    Point2D[] points;
    public int[] solution(int[] X, int[] Y) 
    {
        points = SortAndStorePoints2D(X, Y);

        var result = GetFirstEmptyTriangle(points);

   
        return result;
    }

    private int[] GetFirstEmptyTriangle(Point2D[] input)
    {

        int[] result = new int[]{};

        for (int i = 0; i < input.Length; i++)
        {
            var p1 = input[i];

            for (int j = 0; j < input.Length; j++)
            {
                var p2 = input[j];
                for (int k = 0; k < input.Length; k++)
                {
                    var p3 = input[k];
                    if (IsOnSameLine (p1, p2, p3))
                    {
                        continue;
                    }

                    result = new int[]{p1.index, p2.index, p3.index};
                    bool success = true;


                    for (int l = 0; i < input.Length; i++)
                    {
                       
                        var t = input[l];
                        // point is on triangle
                        if(t == p1 || t == p2 || t == p3 )
                        {
                            continue;
                        }

                        // confine point in smaller region
                        if(p1.x <= t.x && t.x <= p3.x)
                        {
                            var validate  = IsPointInsideTriangle(t,p1,p2,p3);
                            if(validate)
                            {                        
                                success = false;       
                                break;
                            }
                        }

                    }

                    if(success == true )
                    {
                        PrintPoint2DArray(new Point2D[]{p1,p2,p3});
                        return result;
                    }
                }
            }
        }

        return result;
    }

    private bool IsOnSameLine(Point2D p1, Point2D p2, Point2D p3)
    {
        var area = (p2.x - p1.x) * (p3.y - p1.y) - (p3.x - p1.x) * (p2.y - p1.y);
        return Math.Abs(area) <= 1e-6;
    }

    private bool IsPointInsideTriangle(Point2D t, Point2D p1, Point2D p2, Point2D p3)
    {

        var result = new int[]{};

        var alpha = getCrossProduct(t, p1, p2);
        var beta = getCrossProduct(t, p2, p3);
        var gamma = getCrossProduct(t, p3, p1);

        // remark = 0 : if point is on any of the line of triangle.
        // remark = 1 : if point is on any of the left-side of line of triangle.
        // remark = 2 : if point is on any of the right-side of line of triangle.

        if(alpha < 0 && beta < 0 && gamma < 0)
        {
            return true;
        }
        return false;


    }

    private Double getCrossProduct(Point2D t, Point2D p1, Point2D p2)
    {

        double alpha = (t.x - p1.x) * (p2.y - p1.y) - (t.y - p1.y) * (p2.x - p1.x);
        return alpha;
    }





    private Point2D[] SortAndStorePoints2D(int[] X, int[] Y)
    {
        var sortedPoints2D = new Point2D[X.Length];
        for (int i = 0; i < X.Length; i++)
        {
            sortedPoints2D[i] = new Point2D(i, X[i], Y[i]);
        }

        
        Console.WriteLine("Before sorting: ");
        PrintPoint2DArray(sortedPoints2D);

        for (int j = 0; j < sortedPoints2D.Length; j++)
        {
            for (int i = 0; i < sortedPoints2D.Length-1; i++)
            {
                var p1 = sortedPoints2D[i];
                var p2 = sortedPoints2D[i + 1];

                if(p1.x > p2.x || (p1.x == p2.x && p1.y > p2.y) )
                {
                    sortedPoints2D[i] = p2;
                    sortedPoints2D[i + 1] = p1;
                }
               

            }
        }

        Console.WriteLine("After sorting: ");
        PrintPoint2DArray(sortedPoints2D);


        return sortedPoints2D;
        
    }

    private void PrintPoint2DArray(Point2D[] points)
    {
       for (int i = 0; i < points.Length; i++)
        {
           Console.WriteLine( i + " - Pont2D: (" + points[i].x + "," + points[i].y + ") - Index: " + points[i].index );
        }
    }
}



