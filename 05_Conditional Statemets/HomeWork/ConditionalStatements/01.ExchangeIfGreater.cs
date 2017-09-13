using System;

class ExchangeIfGreater
{
	static void Main()
	{
		float
			a = float.Parse(Console.ReadLine()),
			b = float.Parse(Console.ReadLine())
		;
		if(a > b)
		{
			a = a + b;
			b = a - b;
			a = a - b;
		}
		Console.WriteLine("{0} {1}", a, b);
	}
}