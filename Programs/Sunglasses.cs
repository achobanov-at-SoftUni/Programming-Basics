/*Би трябвало да работи в С. Не разбирам защо С# принтва на нов ред, без да му е казано.
Сигурно трябва да се ползвя някоя функция. Ще я довърша, но нямам време преди срока. 
Поздрав, колега.*/

using System;

class Sunglasses
{
	static string[] Print(int a, char b)
	{
		string[] print = new string[a];

		for(int i = 0; i < a; i++)
		{
			print[i] = "b";
		}
		return print;
	}

	static void Main()
	{
		int 
			height = int.Parse(Console.ReadLine()),
			width = height * 2,
			bridge = height / 2 + 1
		;

		for(int i = 0; i < height; i++)
		{
			if(i == 0 | i == height - 1)
			{
				if(i < width - 1 | i > width + height)
				{
					for(int y = 0; y < width - 1; y++)
					{
						Console.WriteLine("*");
					}
				}
				else
				{
					Console.WriteLine(" ");
				}
				
			}
			else
			{
				for(int y = 0; y < width; y++)
				{
					if(i == 0 | i == width - 1)
					{
						Console.WriteLine("*");
					}

					Console.WriteLine("/");
				}
				if(height == 3 | i == bridge)
				{
					for(int y = 0; y < height; y++)
					{
						Console.WriteLine("|");
					}
				}

				for(int y = 0; y < width; y++)
				{
					if(i == 0 | i == width - 1)
					{
						Console.WriteLine("*");
					}

					Console.WriteLine("/");
				}
			}
		}
	}
}