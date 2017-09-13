using System;

class BitDestroyer
{
	static void Main()
	{
		int
			amountNumbers = int.Parse(Console.ReadLine()),
			step = int.Parse(Console.ReadLine()),
			counter = 0,
			bitsCounter = 0,
			newNumber = 0,
			bitValue
		;
		var numbers = new int[amountNumbers];
		for(int i = 0; i < amountNumbers; i++)
		{	
			numbers[i] = int.Parse(Console.ReadLine());
			for(int bit = 7; bit >= 0; bit--)
			{
				if(!((counter % step == 1) || (counter > 0 && step == 1)))
				{
					bitValue = (numbers[i] >> bit) & 1;
					newNumber = (newNumber << 1) | bitValue;
					bitsCounter++;
				}
				counter++;
				if(bitsCounter == 8)
				{
					Console.WriteLine(newNumber);
					newNumber = 0;
					bitsCounter = 0;
				}
			}
		}
		if(bitsCounter != 0)
		{
			newNumber = newNumber << 8 - bitsCounter;
			Console.WriteLine(newNumber);
		}
	}
}