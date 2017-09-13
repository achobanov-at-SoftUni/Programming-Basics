using System;

class CompoundInterest
{
	static void Main()
	{
		int term;
		double
			priceTV,
			interest,
			interestFriend,
			bankCost,
			friendCost
		;
		priceTV = double.Parse(Console.ReadLine());
		term = int.Parse(Console.ReadLine());
		interest = double.Parse(Console.ReadLine());
		interestFriend = double.Parse(Console.ReadLine());

		bankCost = priceTV * Math.Pow(1 + interest, term);
		friendCost = priceTV + interestFriend * priceTV;
		if(bankCost >= friendCost)
		{
			Console.WriteLine("{0:F2} Friend", friendCost);
		}
		else
		{
			Console.WriteLine("{0:F2} Bank", bankCost);
		}
	}
}