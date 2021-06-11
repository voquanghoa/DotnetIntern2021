﻿using System;

 public class Exercise9
{
	public double squareRoot(double n)
    {
        double x = n;
        double root;
        int count = 0;

        if (n == 0) return 0;
        if (n < 0) return -1;
        while (true)
        {
            count++;
            root = x - (Math.Pow(x, 2) - n) / (2*x);
            if (Math.Abs(root - x) < 0.0001)
                break;
            x = root;
        }

        return Math.Round(root,4);
    }
}
