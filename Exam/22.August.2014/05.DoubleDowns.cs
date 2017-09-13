using System;

class DoubleDowns
{
	static void Main()
	{
		int number = int.Parse(Console.ReadLine());
		int[] input = new int[number];
		for(int i = 0; i < number; i++)
		{
			input[i] = int.Parse(Console.ReadLine());
		}
		int vertical = 0,
			currentBit = 0,
			rightBit = 0,
			verticalBit = 0,
			leftBit = 0,
			left = 0,
			right = 0;
		for(int i = 1, n = input.Length; i < n; i++)
		{
			for(int bit = 31; bit >= 0; bit--)
			{
				currentBit = (input[i] >> bit) & 1;
				if(currentBit == 1)
				{
					verticalBit = (input[i - 1] >> bit) & 1;
					rightBit = (input[i - 1] >> bit - 1) & 1;
					leftBit = (input[i - 1] >> bit + 1) & 1;
					if(currentBit == leftBit)
					{
						left++;
					}
					if(currentBit == verticalBit)
					{
						vertical++;
					}
					if(currentBit == rightBit)
					{
						right++;
					}
				}
			}
		}
		Console.WriteLine(left + "\n" + right + "\n" + vertical);
	}
}