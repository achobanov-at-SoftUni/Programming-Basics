using System;
using System.Linq;
using System.Collections.Generic;

class SequenceOfKNumbers
{
	static void Main()
	{
		string[] input = Console.ReadLine().Split(' ').ToArray();
		List<string> output =  new List<string>();
		int k = int.Parse(Console.ReadLine());
		if(k == 1)
		{
			return;
		}
		for(int i = 0, n = input.Length, length = 1; i < n; i++)
		{
			if(i == n - 1)
			{
				ListAdd(input, i, length, output);
				break;
			}
			if(input[i] == input[i + 1])
			{
				length++;
			}
			else if(length != k)
			{
				ListAdd(input, i, length, output);
				length = 1;
			}
			if(length == k)
			{
				i++;
				length = 1;
			}
		}
		foreach(var a in output)
		{
			Console.Write(a + " ");
		}
		Console.WriteLine();
	}

	static void ListAdd(string[] numToAdd, int a, int amaountNums, List<string> output)
	{
		for(int i = 0; i < amaountNums; i++)
		{
			output.Add(numToAdd[a - i]);
		}
	}
}