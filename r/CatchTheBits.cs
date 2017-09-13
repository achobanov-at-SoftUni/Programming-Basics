using System;

class CatchTheBits
{
	static void Main()
	{
		byte 
			number = byte.Parse(Console.ReadLine())
			//step = byte.Parse(Console.ReadLine())
		;
		short[] numbers = new short[number];
		string[] binSequence = new string[number];
		string sequence = string.Empty;
		for(int i = 0; i < number; i++)
		{
			numbers[i] = short.Parse(Console.ReadLine());
			binSequence[i] = Convert.ToString(numbers[i]);
			sequence = "" + binSequence[i];
		}
		Console.WriteLine(sequence);
	}
}