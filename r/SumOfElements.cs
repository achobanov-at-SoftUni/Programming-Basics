using System;
using System.Linq;

class SumOfElements
{
	static void Main()
	{
		string input = Console.ReadLine();
		string[] strings = input.Split(' ');
		int[] numbers = Array.ConvertAll(strings, int.Parse);
		int sum = numbers.Sum();
		int[] diff = new int[numbers.Length];
		for(int i = 0, n = numbers.Length; i < n ; i++)
		{
			if(numbers[i] == sum - numbers[i])
			{
				Console.WriteLine("Yes, sum = {0}", numbers[i]);
				return;
			}
			diff[i] = Math.Abs(sum - 2 * numbers[i]);
		}
		Console.WriteLine("No, diff = {0}", diff.Min());
	}
}