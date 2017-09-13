using System;

class Integers
{
	static void Main()
	{
		int[] numbers = new int[10];
		Random rng = new Random();
		for(int i = 0, n = numbers.Length; i < n; i++)
		{
			numbers[i] = rng.Next(1, 100);
			Console.Write(numbers[i] + " ");
		}
		Console.WriteLine();
		Console.Write(numbers[0] + " ");
		for(int i = 1, n = numbers.Length; i < n; i++)
		{
			numbers[i] += numbers[i - 1];
			Console.Write(numbers[i] + " ");
		}
		Console.WriteLine();
	}
}