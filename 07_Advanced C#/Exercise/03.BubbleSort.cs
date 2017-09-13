using System;

class BubbleSort
{
	static void Main()
	{
		// int[] numbers = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
		int number = int.Parse(Console.ReadLine());
		int[] numbers = new int[number];
		for(int i = 0; i < number; i++)
		{
			numbers[i] = int.Parse(Console.ReadLine());
		}
		Random rng = new Random();
		for(int i = 0, n = numbers.Length; i < n; i++)
		{
			Swap(numbers, i, rng.Next(i, n));
			Console.Write(numbers[i] + " ");
		}
		Console.WriteLine();
		Bubble(numbers);
		foreach(int num in numbers)
		{
			Console.Write(num + " ");
		}
		Console.WriteLine();
	}

	static void Swap(int[] numbers, int a, int b)
	{
		var temp = numbers[a];
		numbers[a] = numbers[b];
		numbers[b] = temp;
	}

	static void Bubble(int[] numbers)
	{
		// for(int i = 0, n = numbers.Length, index = n - 1; index != 0; i++)
		// {
		// 	if(numbers[i] > numbers[i + 1])
		// 	{
		// 		Swap(numbers, i, i + 1);
		// 		index--;
		// 	}
		// 	if(i == n - 2 && index == n - 1)
		// 	{
		// 		break;
		// 	}
		// 	if(i == n - 2)
		// 	{
		// 		i = -1;
		// 		index = n - 1;
		// 	}
		// }
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
}