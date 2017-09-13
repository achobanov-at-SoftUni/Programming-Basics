using System;

class MatrixOfPelindromes
{
	static void Main()
	{
		string input = Console.ReadLine();
		string[] digits = input.Split(' ');
		char letter;
		int
			rows = Convert.ToInt32(digits[0]),
			columns = Convert.ToInt32(digits[1]),
			a = 97;
		for(int row = 0; row < rows; row++)
		{
			for(int column = 0; column < columns; column++)
			{
				for(int letters = 0; letters < 3; letters++)
				{
					if(column > 0 && letters == 1)
					{
						letter = Convert.ToChar(a + row + column);	
					}
					else
					{
						letter = Convert.ToChar(a + row);
					}
					Console.Write(letter);
				}
				Console.Write(" ");
			}
			Console.WriteLine();
		}
	}
}