using System;

class Disk
{
	static void Main()
	{
		int 
			size = int.Parse(Console.ReadLine()),
			radius = int.Parse(Console.ReadLine()),
			center = size / 2
		;
		for(int i = 0; i < size; i++)
		{
			for(int y = 0; y < size; y++)
			{
				if((y - center) * (y - center) + (i - center) * (i - center) <= radius * radius)
				{
					Console.Write("*");
				}
				else
				{
					Console.Write(".");
				}
			}
			Console.WriteLine();
		}
	}
}