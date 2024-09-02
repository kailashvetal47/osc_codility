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
    public int[] solution(int[] X, int[] Y) 
    {
       SortAndStorePoints2D(X, Y);
        int[] result = new int[]{0,1,2};
        return result;
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
           Console.WriteLine( i + " - Pont2D: (" + points[i].x + "," + points[i].y + ")");
        }
    }
}



