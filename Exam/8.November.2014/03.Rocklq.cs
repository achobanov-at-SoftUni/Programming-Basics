using System;

class Rocklq
{
	static void Main()
	{
		int 
			width = int.Parse(Console.ReadLine()),
			mid = width / 2 + 1
		;
		string 
			excess = new string('.', width),
			dress = new string('*', width)
		;
		Console.WriteLine(excess + dress + excess);
		for(int i = 1, n = width * 2 - 1, a = width - 2, b = width * 2 + 1, c = width - 1, d = width * 2; i < n; i++)
		{
			if(i < mid)
			{
				for(int y = 0, m = width * 3; y < m; y++)
				{
					if(y == a || y == b)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(".");
					}
				}
				Console.WriteLine();
				a -= 2;
				b += 2;
			}
			else if(i >= mid && i < width)
			{
				for(int y = 0, m = width * 3; y < m; y++)
				{
					if(y == c || y == d || y == 0 || y == width - 1 || y == width * 2 || y == m - 1)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(".");
					}
				}
				Console.WriteLine();
				c -= 2;
				d += 2;
			}
			else
			{
				if(i == width)
				{
					c = width - 1;
					d = width * 2;
				}
				for(int y = 0, m = width * 3; y < m; y++)
				{
					if(y == c || y == d)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(".");
					}
				}
				Console.WriteLine();
				c--;
				d++;
			}
		}
		Console.WriteLine(dress + dress + dress);
	}
}