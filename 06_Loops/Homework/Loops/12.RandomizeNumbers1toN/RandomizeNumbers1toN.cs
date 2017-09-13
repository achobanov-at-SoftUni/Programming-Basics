using System;
using System.Collections.Generic;

class RandomizeNumbers1toN
{
	static void Main()
	{
		int number = int.Parse(Console.ReadLine());
		var sequence = new List<int>();
		var rng = new Random();
		for(int i = 1; i <= number; i++)
		{
			sequence.Add(i);
		}
		for(int i = 0, n = sequence.Count; i < n; i++)
		{
			Randomize(sequence, i, rng.Next(i, n));
			Console.Write(sequence[i] + " ");
		}
		Console.WriteLine();
	}

	static void Randomize(List<int> sequence, int a, int b)
	{
		var temp = sequence[a];
		sequence[a] = sequence[b];
		sequence[b] = temp;
	}
}