using System;
using System.Linq;

class Pairs
{
	static void Main()
	{
		// Generating the needed arrays.
		string input = Console.ReadLine();
		string[] words = input.Split(' ');
		int[] 
			numbers = Array.ConvertAll(words, int.Parse),
			sum = new int[numbers.Length / 2]
		;
		int amountSums = sum.Length;
		// Looping over the arrays generating sum values. 'i' += 2, because this way
		// we make sure not to overlap numbers.
		for(int i = 0, n = numbers.Length; i < n; i += 2)
		{
			// This makes sure that sum[m] only increments by 1 each loop.
			int m = 0;
			if(i > 0)
			{
				m = i / 2;
			}
			sum[m] = numbers[i] + numbers[i + 1];
		}
		if(amountSums == 1 || (SumEqual(sum, amountSums) == true))
		{
			Console.WriteLine("Yes, value={0}", sum[0]);
		}
		else
		{
			Console.WriteLine("No, maxdiff={0}", MaxDiff(sum, amountSums));
		}
	}
	// SumEqual takes the sum array and amout of sums and returns true if all sums are equal.
	static bool SumEqual(int[] sum, int amountSums)
	{	
		int counter = 0;
		for(int i = 0; i < amountSums; i++)
		{
			if(sum[0] == sum[i])
			{
				counter++;
			}
		}
		if(counter == amountSums)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	// MaxDiff takes sum array and the amout of sums and returns the largest difference value.
	static int MaxDiff(int[] sum, int amountSums)
	{
		int[] diff = new int[amountSums - 1];
		for(int i = 0; i < amountSums - 1; i++)
		{
			diff[i] = Math.Abs(sum[i + 1] - sum[i]);
		}
		int max = diff.Max();
		return max;
	}
}