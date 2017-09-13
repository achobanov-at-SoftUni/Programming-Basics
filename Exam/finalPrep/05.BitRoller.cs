 using System;

class BitRoller
{
	static void Main()
	{
		int number = int.Parse(Console.ReadLine());
		int freeze = int.Parse(Console.ReadLine());
		int roll = int.Parse(Console.ReadLine());
		int output = 0;
		int frozen = 0;
		//string binSequence = Convert.ToString(number, 2);
		for(int bit = 18; bit >= 0; bit--)
		{
			if(bit != freeze)
			{
				int bitValue = (number >> bit) & 1;
				output <<= 1;
				output |= bitValue;
			}
			else
			{
				frozen = (number >> bit) & 1;
			}
		}
		Roll(ref output, roll);
		number = 0;
		for(int bit = 17; bit >= 0; bit--)
		{
			if(bit == Math.Max(freeze - 1, 0))
			{
				number <<= 1;
				number |= frozen;
			}
			int bitValue = (output >> bit) & 1;
			number <<= 1;
			number |= bitValue;
		}
		Console.WriteLine(number);
	}

	static void Roll(ref int output, int amountRotation)
	{	
		for(int i = 0; i < amountRotation ; i++)
		{
			int bitValue = output & 1;
			output >>= 1;
			output |= (bitValue << 17);
		}
	}
}