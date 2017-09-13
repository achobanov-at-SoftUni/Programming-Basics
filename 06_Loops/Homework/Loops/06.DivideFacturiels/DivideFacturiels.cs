using System;

class DivideFacturiels
{
	static void Main()
	{
		int 
			n = int.Parse(Console.ReadLine()),
			k = int.Parse(Console.ReadLine())
		;
		Console.WriteLine("{0}", Facturiel(n) / Facturiel(k));
	}

	static int Facturiel(int number)
	{
		int result = 1;
		for(; number > 0; number--)
		{
			result *= number;
		}
		return result;
	}
}