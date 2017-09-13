using System;

class FibonacciNumbers
{
	static void Main()
	{
		int lenght;
		bool check;
		do
		{
			check = int.TryParse(Console.ReadLine(), out lenght);
		}
		while(check == false);
		long[] fibonacciNumber = new long[lenght];
		fibonacciNumber[0] = 0;
		fibonacciNumber[1] = 1;
		for(int i = 2; i < lenght; i++)
		{
			fibonacciNumber[i] = fibonacciNumber[i - 1] + fibonacciNumber[i - 2];
		}
		string fibonacci = string.Join(" ", fibonacciNumber);
		Console.WriteLine(fibonacci);
	}
}