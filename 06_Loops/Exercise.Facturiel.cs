using System;

class Facturiel
{
	static void Main()
	{
		decimal 
			number = decimal.Parse(Console.ReadLine()),
			result = 1
		;
		for(; number > 0; number--)
		{
			result *= number;
		}
		Console.WriteLine(result);
	}
}