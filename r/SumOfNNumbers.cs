using System;

class SumOfNNumbers
{
	static void Main()
	{
		int amountOfNumbers = int.Parse(Console.ReadLine());
		float sum = 0;
		for(int i = 0; i < amountOfNumbers; i++)
		{
			float number = float.Parse(Console.ReadLine());
			sum = sum + number;
		}
		Console.WriteLine(sum);
	}
}