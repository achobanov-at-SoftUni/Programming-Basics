using System;

class KingOfThieves
{
	static void Main()
	{
		int 
			height = int.Parse(Console.ReadLine()),
			index = 0
		;
		char symbol = Convert.ToChar(Console.ReadLine());
		for(int i = 0; i < height; i++)
		{
			string 
				excess = new string('-', (height - index) / 2),
				diamond = new string(symbol, 1 + index)
			;
			if(i < height / 2)
			{
				Console.WriteLine(excess + diamond + excess);
				 index += 2;
			}
			else if(i == height / 2)
			{
				Console.WriteLine(diamond);
				index -= 2;
			}
			else
			{
				Console.WriteLine(excess + diamond + excess);
				index -= 2;
			}
		}
	}	
}