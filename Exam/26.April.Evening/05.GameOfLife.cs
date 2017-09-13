using System;
using System.Collections.Generic;

class GameOfLife
{
	static int[,] board = new int[10, 10];

	static void Main()
	{
		int 
			coordinatesNumber = int.Parse(Console.ReadLine()),
			x,
			y,
			counter = 0,
			cellsToInvert = 0
		;
		List<int> 
			rowLisit = new List<int>(),
			columnList = new List<int>()
		;
		for(int i = 0; i < coordinatesNumber; ++i)
		{
			x = int.Parse(Console.ReadLine());
			y = int.Parse(Console.ReadLine());
			board[x, 9 - y] = 1; 
		}
		for(int row = 0; row < 10; ++row)
		{
			for(int column = 0; column < 10; ++column)
			{
				counter = BorderExceptions(row, column);
				if((board[row, column] == 0 && counter == 3) ||
					(board[row, column] == 1 && counter < 3) ||
					(board[row, column] == 1 && counter > 4))
				{
					rowLisit.Add(row);
					columnList.Add(column);
					cellsToInvert++;
				}
			}
		}
		for(int i = 0; i < cellsToInvert; ++i)
		{
			if(board[rowLisit[i], columnList[i]] == 0)
			{
				board[rowLisit[i], columnList[i]] = 1;
			}
			else
			{
				board[rowLisit[i], columnList[i]] = 0;
			}
		}
		for(int row = 0; row < 10; ++row)
		{
			for(int column = 0; column < 10; ++column)
			{
				Console.Write(board[row, column]);
			}
			Console.WriteLine();
		}

	}

	static int CountLives(int row, int column, int cellsToCheck)
	{
		int counter = 0;
		for(int i = 0; i < cellsToCheck; ++i, ++column)
		{
			if(board[row, column] == 1)
			{
				counter += 1;
			}
		}
		return counter;
	}

	static int BorderExceptions(int row, int column)
	{
		int counter = 0;
		if(row != 0 && row != 9 && column != 0 && column != 9)
		{
			counter += CountLives(row + 1, column - 1, 3);
			counter += CountLives(row, column - 1, 3);
			counter += CountLives(row - 1, column - 1, 3);
		}
		else if(row == 0 && column == 0)
		{
			counter += CountLives(row, column, 2);
			counter += CountLives(row + 1, column, 2);
		}
		else if(row == 0 && column == 9)
		{
			counter += CountLives(row, column - 1, 2);
			counter += CountLives(row + 1, column - 1, 2);
		}
		else if(row == 9 && column == 0)
		{
			counter += CountLives(row - 1, column, 2);
			counter += CountLives(row, column + 1, 2);
		}
		else if(row == 9 && column == 9)
		{
			counter += CountLives(row - 1, column - 1, 2);
			counter += CountLives(row, column - 1, 2);
		}
		else if(row == 0)
		{
			counter += CountLives(row, column - 1, 3);
			counter += CountLives(row + 1, column - 1, 3);
		}
		else if(row == 9)
		{
			counter += CountLives(row - 1, column - 1, 3);
			counter += CountLives(row, column - 1, 3);
		}
		else if(column == 0)
		{
			counter += CountLives(row - 1, column, 2);
			counter += CountLives(row, column, 2);
			counter += CountLives(row + 1, column, 2);
		}
		else if(column == 9)
		{
			counter += CountLives(row - 1, column - 1, 2);
			counter += CountLives(row, column - 1, 2);
			counter += CountLives(row + 1, column - 1, 2);
		}
		return counter;
	}
}