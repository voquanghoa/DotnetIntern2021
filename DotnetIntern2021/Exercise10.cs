using System;

public class Exercise10
{
    public double cubeRoot(double n)
    {
        double x = n;
        double root;
        int count = 0;

        while (true)
        {
            count++;
            root = x - (Math.Pow(x, 3) - n) / (3 * x * x);
                //0.5 * (x + n / x);

            if (Math.Abs(root - x) < 0.00001)
                break;
            x = root;
        }

        return Math.Round(root,4);
    }
    
}
