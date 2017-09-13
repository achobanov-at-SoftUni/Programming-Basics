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
			number = 0
		;
		int[] 
			numBin= new int[8],
			numbers = new int[amountNumbers]
		;
		var sequence = new List<int>();
		// Storing binary representation of all numbers[i] inside a list.
		for(int i = 0; i < amountNumbers; i++)
		{
			numbers[i] = int.Parse(Console.ReadLine());
			numBin = ToBin(numbers[i]);
			sequence.InsertRange(counter * 8, numBin);
			counter++;
		}
		// Check to return 0 if step equals 1
		if(step == 1)
		{
			Console.WriteLine(0);
			return;
		}
		// BitsKiller
		for(int i = sequence.Count; i >= 0; i--)
		{	
			if(i % step == 1)
			{
				sequence.RemoveAt(i);
			}
		}
		// Padding with zeros at the end, if necessary
		if(sequence.Count % 8 != 0)
		{
			int padding = 8 - (sequence.Count % 8);
			for(int i = 0; i < padding; i++)
			{
				sequence.Add(0);
			}
		}
		// Iterating over each 8 bits ( one number )
		for(int i = 7, power = 0, y = 0; y < sequence.Count; i--, y++, power++)
		{
			// Formula to calculate the decimal representation of the binary sequence
			number = number + (sequence[i]) * ToPower(2, power);
			// We have 8 bits, Print number, reset counters 
			if(i == 0)
			{
				Console.WriteLine(number);
				// Remove the printed number from the sequence.
				sequence.RemoveRange(0, 8);
				number = 0;
				i = 8;
				y = -1;
				power = - 1;
			}
		}
	}
	// Method that returns sequence of zeros and ones, representing 
	// the binary form of the given number. Returns int array
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
	// Takes number and power input and returns the number^power result.
	static int ToPower(int number, int power)
	{
		int numberReturn = number;
		if(power == 0)
		{
			return 1;
		}
		if(number == 1)
		{
			return number;
		}
		for(int i = 0; i < power - 1; i++)
		{
			numberReturn = numberReturn * number;
		}
		return numberReturn;
	}
}
