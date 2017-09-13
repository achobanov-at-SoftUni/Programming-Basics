using System;

class OddAndEvenProduct
{
	static void Main()
	{
		string input = Console.ReadLine();
		string[] numbersString = input.Split(' ');
		int
			sumOdd = 1,
			sumEven = 1,
			counter = 1
		;
		foreach(string num in numbersString)
		{
			int number = int.Parse(num);
			if(counter % 2 == 1)
			{
				sumOdd *= number;
			}
			else
			{
				sumEven *= number;
			}
			counter++;
		}
		if(sumEven == sumOdd)
		{
			Console.WriteLine("yes\nproduct = {0}", sumEven);
		}
		else
		{
			Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", sumOdd, sumEven);
		}
	}
}