using System;
using System.Numerics;

class CatalanNumbers
{
	static void Main()
	{
		BigInteger 
			n = BigInteger.Parse(Console.ReadLine()),
			formula = Facturiel(2 * n) / (Facturiel(n + 1) * Facturiel(n))
		;
		Console.WriteLine(formula);
	}

	static BigInteger Facturiel(BigInteger number)
	{
		BigInteger result = 1;
		for(; number > 0; number--)
		{
			result *= number;
		}
		return result;
	}
}