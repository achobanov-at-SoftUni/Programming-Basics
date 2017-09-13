using System;

class House
{
	static void Main()
	{
		int height = int.Parse(Console.ReadLine());
		string 
			roof = new string('*', height),
			rest = new string('.', height / 4),
			bottom = new string('*', height - 2 * (height / 4))
		;
		// Looping for lines. 'm, n' represent the spots where we must print '*'.
		for(int i = 0, p = height / 2, m = p, n = m; i < p; i++)
		{
			// Looping for individual char printing.
			for(int y = 0; y < height; y++)
			{
				if(y == n || y == m)
				{
					Console.Write("*");
				}
				else
				{
					Console.Write(".");
				}
			}
			Console.WriteLine("");
			// Incrementing one and decrementing the other to get that roof shape.
			m++;
			n--;
		}
		// Prints the base of the roof.
		Console.WriteLine(roof);
		for(int i = height / 2 + 2; i < height; i++)
		{
			for(int y = 0, m = height / 4, n = height - m - 1; y < height; y++)
			{
				if(y == n || y == m)
				{
					Console.Write("*");
				}
				else
				{
					Console.Write(".");
				}
			}
			Console.WriteLine("");
		}
		Console.WriteLine(rest + bottom + rest);
	}
}