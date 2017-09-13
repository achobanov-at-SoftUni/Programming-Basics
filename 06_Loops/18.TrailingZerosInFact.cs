using System;

class TrailingZerosInFact
{
	static void Main()
	{
		int 
			input = int.Parse(Console.ReadLine()),
			numberZeros = 0
		;
		for(int i = 5; i < input; i *= 5)
		{
			numberZeros += input / i;
		}
		Console.WriteLine(numberZeros);
	}
}