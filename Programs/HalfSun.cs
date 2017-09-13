using System;

class HalfSum
{
	static void Main()
	{
		int 
			n = int.Parse(Console.ReadLine()),
			firstSum,
			secondSum
		;

		int[] numbers = new int[2 * n];

		for(int i = 0, y = 2 * n; i < y; i++)
		{
			numbers[i] = int.Parse(Console.ReadLine());
		}

		firstSum = numbers[0];
		for(int i = 0, y = n - 1; i < y  ; i++)
		{
			firstSum = firstSum + numbers[i + 1];
		}

		secondSum = numbers[n];
		for(int i = n, y = n * 2 - 1; i < y; i++)
		{
			secondSum = secondSum + numbers[i + 1];
		}

		if(firstSum == secondSum)
		{
			Console.WriteLine("Yes, sum = " + firstSum);
		}
		else if(firstSum - secondSum < 0)
		{
			int positive = firstSum - secondSum + 2 * (firstSum + secondSum);
			Console.WriteLine("No, diff = " + positive);
		}
		else
		{
			int difference = firstSum - secondSum;
			Console.WriteLine("No, diff = " + difference);
		}

	}
}