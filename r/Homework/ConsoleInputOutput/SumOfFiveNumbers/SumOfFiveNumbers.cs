using System;

class SumOfFiveNumbers
{
	static void Main()
	{
		string input = Console.ReadLine();
		string[] numbers = input.Split(' ');
		int sum = 0;
		foreach(string number in numbers)
		{
			int a = int.Parse(number);
			sum = sum + a;
		}
		Console.WriteLine("{0}", sum);
	}
}