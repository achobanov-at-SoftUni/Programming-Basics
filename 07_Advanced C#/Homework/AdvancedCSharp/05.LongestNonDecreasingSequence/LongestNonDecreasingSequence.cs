
// After a couple of days of bashing agains the wall - this is all that I have achieved.
// This program will succesfuly print the length of the longest non-decreasing seuquence,
// but hell I can't get it to print it out.

using System;
using System.Linq;

class LongestNonDecreasingSequence
{
	static void Main()
	{
		int[] 
			numbers = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray(),
			length = new int[numbers.Length]
			// lengthS = new int[numbers.Length],
			// number = new int[numbers.Length]
			;
		int 
			n = numbers.Length,
			maxLength = 0
			// holder = 0
		;
		for(int i = 0; i < n; i++)
		{
			length[i] = 1;
			//lengthS[1] = 1;
			//number[i] = numbers[i];
			// if(maxLength == 0 && i == 1 || i == 0)
			// {
			// 	lengthS[i] = length[i];
			// }
			for(int y = 0; y < i; y++)
			{
				if(numbers[y] <= numbers[i] && length[y] + 1 > length[i])
				{
					length[i] = length[y] + 1;
					if(length[i] >= maxLength)
					{
						maxLength = length[i];
						//lengthS[i] = maxLength;
					}
				}
			}
		}
		Console.WriteLine(maxLength);
		// for(int i = 0; i < n; ++i)
		// {
		// 	Console.WriteLine("Length: {0}\nNumber: {1}\n", lengthS[i], number[i]);
		// }
		// // for(int a = 0; a < n; ++a)
		// // {
		// // 	for(int i = 0; i < n; ++i)
		// // 	{
		// // 		if(number[i] <= maxNumber && lengthS[i] == 1 + i)
		// // 		{
		// // 			result[counter] = number[i];
		// // 			counter++;
		// // 			if(counter == maxLength)
		// // 			{
		// // 				counter = 0;
		// // 			}
		// // 		}
		// // 	}
		// // }

		// int maxNumber = number[Array.IndexOf(lengthS, maxLength)];
		// int counter = maxLength - 1;
		// int prevLength = maxLength;
		// // Console.WriteLine(maxNumber);

		// int[] result = new int[maxLength];
		// for(int i = n - 1, lengthCounter = 0; i >= 0; --i)
		// {
		// 	for(int y = 0; y < n; y++)
		// 	{
		// 		if(number[y] <= number[i] && lengthS[i] == 1 + lengthCounter)
		// 		{
		// 			result[counter] = numbers[i];
		// 			counter--;
		// 			if(counter == - 1)
		// 			{
		// 				counter = maxLength - 1;
		// 			}
		// 			lengthCounter++;
		// 			Console.Write(number[i] + " ");
		// 		}
		// 	}
		// }

		// // for(int i = n - 1, b = 0; i >= 0; --i)
		// // {	
		// // 	for(int a = n - 1; a >= 0; --a)
		// // 	{
		// // 		if(number[a] <= number[i])
		// // 		{
		// // 			result[counter] = number[a];
		// // 			counter--;
		// // 			if(counter == - 1)
		// // 			{
		// // 				counter = maxLength - 1;
		// // 			}
		// // 			if(lengthS[a] == maxLength - b)
		// // 			{
		// // 				b++;
		// // 				if(b == maxLength)
		// // 				{
		// // 					b = 0;
		// // 				}
		// // 			}
		// // 			// prevLength = maxLength - b;
		// // 		}
		// // 	}
		// // }

		// foreach(int num in result)
		// {
		// 		Console.Write(num + " ");
		// }
		// Console.WriteLine();
	}
}