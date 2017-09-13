using System;

class PokerStraight
{
	static void Main()
	{
		int 
			weight = int.Parse(Console.ReadLine()),
			count = 0
		;
		for(int a = 1; a <= 10; a++)
		{
			int b = a + 1;
			int c = b + 1;
			int d = c + 1;
			int e = d + 1;
			for(int aSuit = 1; aSuit <= 4; aSuit++)
			{
				for(int bSuit = 1; bSuit <= 4; bSuit++)
				{
					for(int cSuit = 1; cSuit <= 4; cSuit++)
					{
						for(int dSuit = 1; dSuit <= 4; dSuit++)
						{
							for(int eSuit = 1; eSuit <= 4; eSuit++)
							{
								int currentWeight = 50 * e + eSuit + 40 * d + dSuit + 30 * c + cSuit + 20 * b + bSuit + 10 * a + aSuit;
								if(currentWeight == weight)
								{
									count++;
								}
							}		
						}
					}
				}
			}
		}
		Console.WriteLine(count);
	}
	// Prints the Cards.
	// static void PrintCards(int a, int b, int c, int d, int e, int aSuit, int bSuit, int cSuit, int dSuit, int eSuit)
	// {
	// 	int[] holder = {a, b, c, d, e, aSuit, bSuit, cSuit, dSuit, eSuit};
	// 	string[] output = new string[10];
	// 	for(int i = 0; i < 10; i++)
	// 	{
	// 		if(i < 5)
	// 		{
	// 			switch(holder[i])
	// 			{
	// 				case 1: output[i] = "A"; break;
	// 				case 11: output[i] = "J"; break;
	// 				case 12: output[i] = "Q"; break;
	// 				case 13: output[i] = "K"; break;
	// 				case 14: output[i] = "A"; break;
	// 				default: output[i] = Convert.ToString(holder[i]); break;
	// 			}
	// 		}
	// 		else
	// 		{
	// 			switch(holder[i])
	// 			{
	// 				case 1: output[i] = "C"; break;
	// 				case 2: output[i] = "D"; break;
	// 				case 3: output[i] = "H"; break;
	// 				case 4: output[i] = "S"; break;
	// 			}
	// 		}
	// 	}
	// 	Console.WriteLine("({0}{5} {1}{6} {2}{7} {3}{8} {4}{9})",
	// 						output[0], output[1], output[2], output[3], output[4], output[5], output[6], output[7], output[8], output[9]);
	// }
}
