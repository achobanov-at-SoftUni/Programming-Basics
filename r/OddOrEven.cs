using System;

class IsOdd
{
	static void Main()
	{
		int number = int.Parse(Console.ReadLine());
		if( number % 2 != 0)
		{
			Console.WriteLine("True");
		}
		else
		{
			Console.WriteLine("False");
		}
	}
}