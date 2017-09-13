using System;
using System.Linq;

class LongestAreaInArray
{
	static void Main()
	{
		int number = int.Parse(Console.ReadLine());
		int[] length = Enumerable.Repeat(0, number).ToArray();
		string[] elements = new string[number];
		for(int i = 0; i < number; i++)
		{
			elements[i] = Console.ReadLine();
		}
		for(int i = 0; i < number; i++)
		{
			for(int y = 0; y < number; y++)
			{
				if(elements[i] == elements[y])
				{
					length[i] += 1;
				}
			}
		}
		// Below follows my personal solution. The upper version, however is clearly superior in both
		// Readability and performance.

		// for(int i = 0, y = 0; i < number; i++)
		// {
		// 	for(; y < number; y++)
		// 	{
		// 		if(elements[i] == elements[y])
		// 		{
		// 			length[i] += 1;
		// 			if(y == number - 1)
		// 			{
		// 				break;
		// 			}
		// 		}
		// 		else
		// 		{
		// 			i = y - 1;
		// 			break;
		// 		}
		// 	}
		// }
		Console.WriteLine(length.Max());
		for(int i = 0; i < length.Max(); i++)
		{
			Console.WriteLine(elements[Array.IndexOf(length, length.Max())]);
		}
	}
}