using System;

class RandomNumbersInRage
{
	static void Main()
	{
		int
			numbers = int.Parse(Console.ReadLine()),
			min = int.Parse(Console.ReadLine()),
			max = int.Parse(Console.ReadLine())
		;
		var rng = new Random();
		for(int i = 0; i < numbers; i++)
		{
			Console.Write(rng.Next(min, max) + " ");
		}
	}
}