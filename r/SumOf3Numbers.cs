using System;

class SumOf3Numbers
{
	static void Main()
	{
		int
			a = int.Parse(Console.ReadLine()),
			b = int.Parse(Console.ReadLine()),
			c = int.Parse(Console.ReadLine())
		;
		Console.WriteLine("Sum of {0}, {1} and {2} is: {3}", a, b, c, a + b + c);
	}
}