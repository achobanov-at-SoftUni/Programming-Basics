using System;
using System.Numerics;

class TrailingZerosInN
{
	static void Main()
	{
		int 
			input = int.Parse(Console.ReadLine()),
			counter = 0
		;
		BigInteger fact = Facturiel((BigInteger)input);
		string sequence = Convert.ToString(fact);
		for(int i = sequence.Length - 1; sequence[i] == '0'; i--)
		{
			counter++;
		}
		Console.WriteLine(counter);
	}

	static BigInteger Facturiel(BigInteger input)
	{
		BigInteger result = 1;
		for(; input > 1; input--)
		{
			result *= input;
		}
		return result;
	}
}