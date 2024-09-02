
using System;
using System.Collections.Generic;

namespace code_challenges.Task02;

public class Solution {
    public int[] solution(int[] X, int[] Y) {
        int N = X.Length;
        

        for (int i = 0; i < N - 2; i++) {
            for (int j = i + 1; j < N - 1; j++) {
                for (int k = j + 1; k < N; k++) {
                    if (isValidTriangle(X[i], Y[i], X[j], Y[j], X[k], Y[k], X, Y)) {
                        return new int[] { i, j, k };
                    }
                }
            }
        }
        
 
        return new int[0];
    }


    private bool isValidTriangle(int x1, int y1, int x2, int y2, int x3, int y3, int[] X, int[] Y) {
        // Calculate the area of the triangle using the Shoelace formula
        double area = 0.5 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1));
        if (area == 0) {
            return false; // Points are collinear
        }


        for (int i = 0; i < X.Length; i++) {
            if (i == x1 || i == x2 || i == x3) {
                continue; // Skip the vertices
            }

            double alpha = ((y2 - y3) * (X[i] - x1) + (x3 - x2) * (Y[i] - y1)) / area;
            double beta = ((y3 - y1) * (X[i] - x2) + (x1 - x3) * (Y[i] - y2)) / area;
            double gamma = 1 - alpha - beta;

            if (alpha >= 0 && beta >= 0 && gamma >= 0) {
                return false; // Point lies inside the triangle
            }
        }

        return true;
    }
}