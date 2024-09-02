namespace code_challenges.Task01;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;


public class Point2D {
  public int x;
  public int y;

  public Point2D(int x, int y) {
    this.x = x;
    this.y = y;
  }
};

public class Solution {

   readonly Point2D ORIGIN = new Point2D(0,0) {};

    public int solution(Point2D[] A) 
    {

      int result = 0;
      HashSet<Point2D> processedPoints = new HashSet<Point2D>();

      foreach( Point2D p in  A )
      {
        Console.WriteLine("Point : " + p.x + " , " + p.y);

        if( p.x == 0 && p.y == 0 )
        {
          continue;
        }

        
        if(!processedPoints.Contains(p))
        {
          Console.WriteLine("Processing Line Origin to P " + p.x + " , " + p.y);

          result++;
          processedPoints.Add(p);
          foreach( Point2D q in  A )
          {
             if(!processedPoints.Contains(p) && !p.Equals(ORIGIN))
             {
                if(IsPointOnLine(ORIGIN,p,q))
                {
                  processedPoints.Add(q);
                }
             }

          }
         

      
        }
      }

      return result;
    }

    private bool IsPointOnLine(Point2D p1, Point2D p2, Point2D p)
    {
      bool result = false;
      var area = (p2.x - p1.x) * (p.y - p1.y) - (p.x - p1.x) * (p2.y - p1.y);
      if(Math.Abs(area) <= 1e-6)
      {
        result = true;
      }
      Console.WriteLine("Result : " + result );
      return result;

    }
}
