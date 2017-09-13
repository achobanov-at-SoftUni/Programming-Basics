using System;

class HextoDecNum
{
	static void Main()
	{
		string input = Console.ReadLine();
		char[] symbols = input.ToCharArray();
		var numbers = new int[input.Length];
		long number = 0;
		for(int n = input.Length - 1, power = 0; n >= 0; n--, power++)
		{
			switch(symbols[n])
			{
			case 'A': numbers[n] = 10; break;
			case 'B': numbers[n] = 11; break;
			case 'C': numbers[n] = 12; break;
			case 'D': numbers[n] = 13; break;
			case 'E': numbers[n] = 14; break;
			case 'F': numbers[n] = 15; break;
			default: numbers[n] = (int)Char.GetNumericValue(symbols[n]); break;
			}
			number = number + numbers[n] * (long)Math.Pow(16, power);
		}
		Console.WriteLine(number);
	}
}