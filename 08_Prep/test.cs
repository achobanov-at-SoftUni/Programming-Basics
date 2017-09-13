using System;

class test
{
	static void Main()
	{
		int term = int.Parse(Console.ReadLine());
		float
			priceTV = float.Parse(Console.ReadLine()),
			interest = float.Parse(Console.ReadLine()),
			interestFriend = float.Parse(Console.ReadLine()),
			bankCost = priceTV * (float)Math.Pow(1 + interest, term),
			friendCost = priceTV + interestFriend / 100 * priceTV;
		if(bankCost >= friendCost)
		{
			Console.WriteLine(friendCost + "Friend");
		}
		else
		{
			Console.WriteLine(bankCost + "Bank");
		}
	}
}