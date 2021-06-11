using System;

public class Exercise7
{
	public int giaiThua(int n)
	{
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * giaiThua(n - 1);
        }
    }
}
