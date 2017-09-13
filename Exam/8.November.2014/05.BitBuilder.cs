using System;

class BitBuilder
{
	static void Main()
	{
		long 
			number = long.Parse(Console.ReadLine()),
			numberValue = 0
		;
		while(true)
		{
			string breakCheck = Console.ReadLine();
			if(breakCheck == "quit")
			{
				break;
			}
			int position = int.Parse(breakCheck);
			string order = Console.ReadLine();
			string binSequence = Convert.ToString(number, 2);
			if(order == "flip")
			{
				number ^= (1 << position);
			}
			else if(order == "remove")
			{
				int bitValue;
				for(int bit = binSequence.Length - 1; bit >= 0; bit--)
				{
					if(bit != position)
					{
						bitValue = (int)(number >> bit) & 1;
						numberValue <<= 1; 
						numberValue ^= bitValue;
					}
				}
				number = numberValue;
				numberValue = 0;
			}
			else if(order == "insert")
			{
				int bitValue;
				for(int bit = binSequence.Length - 1; bit >= 0; bit--)
				{
					if(position > bit && bit == binSequence.Length - 1)
					{
						numberValue |= 1;
						numberValue <<= position - bit - 1;
					}
					bitValue = (int)(number >> bit) & 1;
					numberValue <<= 1;
					numberValue ^= bitValue;
					if(bit == position)
					{
						numberValue <<= 1;
						numberValue |= 1;
					}
				}
				number = numberValue;
				numberValue = 0;
			}
		}
		Console.WriteLine(number);
	}
}