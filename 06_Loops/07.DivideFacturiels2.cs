using System;
using System.Numerics;

class DivideFacturiels2
{
	static void Main()
	{
		BigInteger
			n = BigInteger.Parse(Console.ReadLine()),
			k = BigInteger.Parse(Console.ReadLine()),
			result = Facturiel(n) / (Facturiel(k) * Facturiel(n - k))
		;
		Console.WriteLine(result);
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