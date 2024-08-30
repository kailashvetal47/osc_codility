namespace code_challenges.Task01;

using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Point2D {
  public int x;
  public int y;
};

class Solution {
    public int solution(Point2D[] A) {

      int result = 0;
      var origin = new Point2D {x = 0, y = 0};
        foreach( var p in A)
        {
            int rayCount = 0;

            foreach(var q in A)
            {
                if(IsPointOnLine(origin, p, q))
                {
                    rayCount++;
                }
            }

        }

      return result;
    }

    private bool IsPointOnLine(Point2D p1, Point2D p2, Point2D p)
    {
            // Calculate the cross product of vectors p1-p and p2-p
                int crossProduct = (p2.X - p1.X) * (p.Y - p1.Y) - (p.X - p1.X) * (p2.Y - p1.Y);

                // A point is on the line if the cross product is zero
                return crossProduct == 0;

    }
}
