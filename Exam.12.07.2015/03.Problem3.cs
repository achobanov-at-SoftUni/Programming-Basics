using System;

class Problem3
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		string neck = new string('*', n + 1);
		string excess = new string(' ', n / 2);
		string bottom = new string('*', n * 2);
		Console.WriteLine(excess + neck + excess);
		for(int i = 1, o = 3 * n + 1, m = n * 2, a = n / 2, b = a + n; i < o - 1; i++)
		{
			for(int y = 0; y < m; y++)
			{
				if(y == a || y == b)
				{
					Console.Write("*");
				}
				else
				{
					if(i >= n && i < n * 2)
					{
						Console.Write(".");
					}
					else if(i >= n * 2)
					{
						Console.Write("@");
					}
					else
					{
						Console.Write(" ");
					}
				}
			}
			if(i >= n / 2 + 1 && i < n)
			{
				a--;
				b++;
			}
			Console.WriteLine();
		}
		Console.WriteLine(bottom);
	}
}