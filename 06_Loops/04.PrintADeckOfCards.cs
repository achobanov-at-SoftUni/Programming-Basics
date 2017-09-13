using System;

class DeckOfCards
{
	static void Main()
	{
		char 
			clubs = '\u2663',
			diamonds = '\u2666',
			hearths = '\u2665',
			spades = '\u2660'
		;
		for(int i = 2; i < 15; i++)
		{
			if(i < 11)
				Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", i, clubs, diamonds, hearths, spades);
			else
			{
				char card = 'a';
				switch(i)
				{
					case 11: card = 'J'; break;
					case 12: card = 'Q'; break;
					case 13: card = 'K'; break;
					case 14: card = 'A'; break;
				}
				Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", card, clubs, diamonds, hearths, spades);
			}
		}
	}
}