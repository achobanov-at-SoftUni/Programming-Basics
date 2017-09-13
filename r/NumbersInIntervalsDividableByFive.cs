using System;

class NumbersInIntervalDividableByFive
{
	static void Main()
	{
		int
			a = int.Parse(Console.ReadLine()),
			b = int.Parse(Console.ReadLine()),
			count = 0
		;
		for(float i = a; i <= b; i++)
		{
			if(i % 5 == 0)
			{
				count++;
			}
		}
		Console.WriteLine(count);
	}
}