using System;
using System.Linq;

class JoinLists
{
	static void Main()
	{
		string[] 
			listSymbols = Console.ReadLine().Split(' '),
			listSymbols2 = Console.ReadLine().Split(' ')
		;
		int[]
			list = listSymbols.Select(a => int.Parse(a)).ToArray(),
			list2 = listSymbols2.Select(a => int.Parse(a)).ToArray(),
			joined = new int[list.Length + list2.Length],
			output = new int[list.Length + list2.Length]
		;
		for(int i = 0, n = list.Length; i < n; i++)
		{
			joined[i] = list[i];
		}
		for(int i = list.Length, y = 0, n = list2.Length; y < n; i++, y++)
		{
			joined[i] = list2[y];
		}
		Bubble(joined);
		output = joined.Distinct().ToArray();
		foreach(int num in output)
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
					int temp = numbers[y];
					numbers[y] = numbers[y + 1];
					numbers[y + 1] = temp;
				}
			}
		}
	}
}