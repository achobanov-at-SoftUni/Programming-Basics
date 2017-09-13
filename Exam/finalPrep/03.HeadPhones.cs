using System;

class HeadPhones
{
	static void Main()
	{
		int diameter = int.Parse(Console.ReadLine());
		string headphone = new string('*', diameter + 2);
		string excess = new string('-', diameter / 2);
		Console.WriteLine(excess + headphone + excess);
		int a = diameter / 2;
		int b = a;
		int c = diameter * 2 - a;
		int d = c;
		for(int height = 1, n = diameter * 2, m = diameter * 2 + 1; height < n; height++)
		{
			if(height < diameter)
			{
				for(int width = 0; width < m; width++)
				{
					if(width == a || width == c)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write("-");
					}
				}
			}
			else
			{
				for(int width = 0; width < m; width++)
				{
					if(width >= a && width <= b || width >= c && width <= d)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write("-");
					}
				}
				if(height >= diameter + diameter / 2)
				{
					a++;
					b--;
					c++;
					d--;
				}
				else
				{
					a--;
					b++;
					c--;
					d++;
				}
			}
			Console.WriteLine();
		}
	}
}