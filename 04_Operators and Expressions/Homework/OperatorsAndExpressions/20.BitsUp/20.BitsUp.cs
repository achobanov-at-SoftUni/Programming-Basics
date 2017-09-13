using System;
using System.Collections.Generic;

class BitKiller
{
	static void Main()
	{
		int
		amountNumbers = int.Parse(Console.ReadLine()),
		step = int.Parse(Console.ReadLine()),
		counter = 0,
		index = 0
			;
		int[] 
		numBin= new int[8],
		numbers = new int[amountNumbers]
			;
		var sequence = new List<int>();
		for(int i = 0; i < amountNumbers; i++)
		{
			numbers[i] = int.Parse(Console.ReadLine());
			Console.WriteLine(numbers[i]);
			numBin = ToBin(numbers[i]);
			sequence.InsertRange(counter * 8, numBin);
			counter++;
		}
		foreach(int i in sequence)
		{
			Console.Write(i);
		}
		Console.WriteLine("");
		Console.WriteLine("Sequence count = {0}", sequence.Count);
		for(int i = 0; i < sequence.Count; i++)
		{	
			//Console.WriteLine("{0}, {1}", i, i % step);
			if(i % step == 1)
			{
				Console.WriteLine("Removing bit: {0}", i);
				sequence.RemoveAt(i);
				//index++;
			}
		}
		// if(sequence.Count % amountNumbers * 8 != 0)
		// {
		// 	int padding = amountNumbers * 8 - (sequence.Count % (amountNumbers * 8));
		// 	for(int i = 0; i < padding; i++)
		// 	{
		// 		sequence.Add(0);
		// 	}
		// }
		foreach(int i in sequence)
		{
			Console.Write(i);
		}
		Console.WriteLine("");


	}

	static int[] ToBin(int number)
	{
		var binSequence = new int[8];
		for(int i = 7; i >= 0; number /= 2, i--)
		{
			if(number % 2 == 0 || (number == 0 && i >= 0))
			{
				binSequence[i] = 0;
			}
			else
			{
				binSequence[i] = 1;
			}
		}
		return binSequence;
	}
}
