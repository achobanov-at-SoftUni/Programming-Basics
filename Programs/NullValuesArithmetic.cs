using System;

class NullValuesArithmetic
{
	static void Main()
	{
		int? a = null;
		double? b = null;

		Console.WriteLine(a + "\n" + b);

		a += 10;

		b += 15.5;

		Console.WriteLine(a + "\n" + b);
	}
}