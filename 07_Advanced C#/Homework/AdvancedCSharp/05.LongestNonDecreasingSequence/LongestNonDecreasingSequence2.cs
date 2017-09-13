
// This is something that came up during my tests. It didn't get very far.

using System;

class LongestNonDecreasingSequence
{
	static void Main()
	{
		string input = Console.ReadLine();
		string[] chars = input.Split(' ');
		int[] numbers = new int[input.Length];
		int 
			n = chars.Length,
			subLength = 0,
			maxLength = 0,
			indexStart = 0,
			indexPrefix = 0
			// indexEnd = 0
		;
		for(int i = 0; i < n; i++)
		{
			numbers[i] = int.Parse(chars[i]);
			if(i == 0 || numbers[i] >= numbers[i -1])
			{
				subLength += 1;
			}
			else if(subLength > maxLength)
			{
				indexStart = i - subLength;
				// indexEnd = i;
				maxLength = subLength;
				subLength = 1;
			}
		}
		for(int i = 0; i < maxLength; i++)
		{
			Console.Write(numbers[indexStart + i] + " ");
		}
		Console.WriteLine();
	}
}