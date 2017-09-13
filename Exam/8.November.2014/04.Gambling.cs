using System;
using System.Linq;

class Gambling
{
	static void Main()
	{
		int 
			houseHand = 0,
			highestCard = 14,
			lowestCard = 2,
			allHands = 0,
			winningHand = 0
		;
		decimal 
			cash = decimal.Parse(Console.ReadLine()),
			ratio
		;
		string[] houseCards = Console.ReadLine().Split(' ');
		for(int i = 0, n = houseCards.Length; i < n; i++)
		{
			switch(houseCards[i])
			{
				case "J": houseHand += 11; break;
				case "Q": houseHand += 12; break;
				case "K": houseHand += 13; break;
				case "A": houseHand += 14; break;
				default: houseHand += int.Parse(houseCards[i]); break;
			}
		}
		for(int a = highestCard; a >= lowestCard; a--)
		{
			for(int b = highestCard; b >= lowestCard; b--)
			{
				for(int c = highestCard; c >= lowestCard; c--)
				{
					for(int d = highestCard; d >= lowestCard; d--)
					{
						int hand = a + b + c + d;
						if(hand > houseHand)
						{
							winningHand++;
						}
						allHands++;
					}
				}
			}
		}
		ratio = (decimal)winningHand / allHands;
		Console.WriteLine(ratio);
		if(ratio < 0.5m)
		{
			Console.WriteLine("FOLD\n{0:F2}", cash * 2 * ratio);
		}
		else 
		{
			Console.WriteLine("DRAW\n{0:F2}", cash * 2 * ratio);
		}
	}
}