using System;

class SortingNumbers
{
	static void Main()
	{
		int number = int.Parse(Console.ReadLine());
		int[] numbers = new int[number];
		for(int i = 0; i < number; i++)
		{
			numbers[i] = int.Parse(Console.ReadLine());
		}
		Bubble(numbers);
		foreach(int num in numbers)
		{
			Console.Write(num + " ");
		}
		Console.WriteLine();
	}

	static void Bubble(int[] numbers)
	{
		for(int i = 0, n = numbers.Length; i < n; i++)
		{
			for(int y = 0; y < n - 1; y++)
			{
				if(numbers[y] > numbers[y + 1])
				{
					Swap(numbers, y, y + 1);
				}
			}
		}
	}

	static void Swap(int[] numbers, int a, int b)
	{
		var temp = numbers[a];
		numbers[a] = numbers[b];
		numbers[b] = temp;
	}
}