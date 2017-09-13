/* C# Basics Exam, 25/July/2014 */

using System;

class ChangeEvenBits
{
	static void Main()
	{
		int amount = int.Parse(Console.ReadLine());
		string[] length = new string[amount];
		for(int i = 0; i < amount; i++)
		{
			int numLength = int.Parse(Console.ReadLine());
			// Getting the number of bits we need to change
			length[i] = Convert.ToString(numLength, 2);
		}
		ulong number = ulong.Parse(Console.ReadLine());
		int toggleBit,
			changedBits = 0;
		// Loop for every amount of bits to change.
		for(int i = 0, n = length.Length; i < n; i++)
		{
			for(int bit = 0, m = length[i].Length * 2; bit < m; bit++)
			{
				// Checks if bit is equal to zero.
				int bitCheck = ((int)number >> bit) & 1;
				if(bit % 2 == 0 && bitCheck == 0)
				{
					toggleBit = 1 << bit;
					number |= (uint)toggleBit;
					changedBits++;
				}
			}
		}
		Console.WriteLine(number + "\n" + changedBits);
	}
}