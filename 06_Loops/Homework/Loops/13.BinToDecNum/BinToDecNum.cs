using System;

class BinToDecNum
{
	static void Main()
	{
		string bin = Console.ReadLine();
		char[] digits = bin.ToCharArray();
		int[] bits = Array.ConvertAll(digits, c => (int)Char.GetNumericValue(c));
		long number = 0;
		for(int n = bin.Length - 1, power = 0; n >= 0; n--, power++)
		{
			number = number + bits[n] * (int)Math.Pow(2, power);
		}
		Console.WriteLine(number);
	}

}