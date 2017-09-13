using System;

class CalculateGCD
{
	static void Main()
	{
		int 
			a = int.Parse(Console.ReadLine()),
			b = int.Parse(Console.ReadLine()),
			gcd = 0
		;
		for(; a % b != 0; a = b, b = a / b)
		{
			gcd = a % b;
		}	
		Console.WriteLine(gcd);
	}
}