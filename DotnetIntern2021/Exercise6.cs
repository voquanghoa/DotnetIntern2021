using System;

public class Exercise6
{
	public int sum(int n)
	{
		int length = n * (n + 1);
		int ans = (length + 1) * length / 2;
		return ans * 2 - 1 - length;
	}
}
