using System;

class ChessQueens
{
	static void Main()
	{
		int size = int.Parse(Console.ReadLine()),
			distance = int.Parse(Console.ReadLine()) + 1,
			counter = 0;
		// For loops for coordinates of both queens. 
		for(int firstRow = 0; firstRow < size; firstRow++)
		{
			for(int firstCol = 1; firstCol <= size; firstCol++)
			{
				// First Queen.
				char firstQueenRow = Convert.ToChar(97 + firstRow);
				int firstQueenCol = firstCol;
				for(int row = 0; row < size; row++)
				{
					for(int col = 1; col <= size; col++)
					{
						// Second Queen.
						char secondQueenRow = Convert.ToChar(97 + row);
						int secondQueenCol = col;
						// Condition
						bool rowPair = row == firstRow && Math.Abs(col - firstCol) == distance,
							 colPair = col == firstCol && Math.Abs(row - firstRow) == distance,
							 diagPair = Math.Abs(row - firstRow) == distance && Math.Abs(col - firstCol) == distance;
						if(rowPair || colPair || diagPair)
						{
							Console.WriteLine("{0}{1} - {2}{3}", 
								firstQueenRow, firstQueenCol, secondQueenRow, secondQueenCol);
							counter++;
						}
					}
				}
			}
		}
		if(counter == 0)
		{
			Console.WriteLine("No valid positions");
		}
	}
}