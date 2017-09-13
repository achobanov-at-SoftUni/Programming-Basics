using System;

class ExchangeVarValues
{
	static void Main()
	{
		int a = 5, b = 10;

		Console.WriteLine(a + "\n" + b);

		a = a + b;
		b = a - b;
		a = a - b;

		Console.WriteLine(a + "\n" + b);
	}
}