using System;
using System.Linq;

class MinMaxSumAverage
{
	static void Main()
	{
		int amountNumbers = int.Parse(Console.ReadLine());
		var numbers = new int[amountNumbers];
		for(int i = 0; i < amountNumbers; i++)
		{
			numbers[i] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine
		(
@"min = {0}
max = {1}
sum = {2}
avg = {3:F2}
",
			numbers.Min(), numbers.Max(), numbers.Sum(), numbers.Average()
		);
	}
}