using System;

class ChessboardGame
{
	static void Main()
	{
		int 
			width = int.Parse(Console.ReadLine()),
			sumBlack = 0,
			sumWhite = 0,
			symbol
		;
		string input = Console.ReadLine();
		//char[] board = new char[width * width];
		for(int i = 0, n = input.Length, m = width * width; i < m && i < n; i++)
		{
			if((input[i] > 47 && input[i] < 58) ||
				(input[i] > 64 && input[i] < 91) ||
				(input[i] > 96 && input[i] < 123))
			{
				symbol = Convert.ToChar(input[i]);
			}
			else
			{
				symbol = 0;
			}
			if(i % 2 == 0)
			{
				if(symbol > 64 && symbol < 91)
				{
					sumWhite += symbol;
				}
				else
				{
					sumBlack += symbol;
				}
			}
			else
			{
				if(symbol > 64 && symbol < 91)
				{
					sumBlack += symbol;
				}
				else
				{
					sumWhite += symbol;
				}
			}
		}
		if(sumBlack > sumWhite)
		{
			Console.WriteLine("The winner is: black team\n{0}", sumBlack - sumWhite);
		}
		else if(sumWhite > sumBlack)
		{
			Console.WriteLine("The winner is: white team\n{0}", sumWhite - sumBlack);
		}
		else
		{
			Console.WriteLine("Equal result: {0}", sumWhite);
		}
	}
}