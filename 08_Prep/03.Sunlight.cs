using System;

class Sunlight
{
	static void Main()
	{
		int size = int.Parse(Console.ReadLine());
		for(int i = 0, n = size * 3, a = 1, b = size * 3 - 2; i < n; ++i)
		{
			for(int y = 0; y < n; ++y)
			{
				if(i > size - 1 && i < size * 2 && i != (size * 3) / 2)
				{
					if(y < size || y >= size * 2)
					{
						Console.Write(".");
					}
					else
					{
						Console.Write("*");
					}
				}
				else
				{
					if(y == (size * 3) / 2 || i == (size * 3) / 2 || (y == a && (i != 0 && i != size * 3 - 1)) || (y == b  && (i != 0 && i != size * 3 - 1)))
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(".");
					}
				}
			}
			Console.WriteLine();
			if(i < size && i != 0)
			{
				a++;
				b--;
			}
			if(i >= size * 2 - 1 && i != size * 3 - 1)
			{
				a--;
				b++;
			}
		}
	}
}