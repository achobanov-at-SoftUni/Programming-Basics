using System;

class BitsAtCrossroads
{
	static int 
		size = int.Parse(Console.ReadLine());

	static void Main()
	{
		int[] board = new int[size];
		int crossRoads = 0;
		string input;
		do
		{
			input = Console.ReadLine();
			if(input == "end")
			{
				break;
			}
			string[] symbols = input.Split(' ');
			int
				row = Convert.ToInt32(symbols[0]),
				col = Convert.ToInt32(symbols[1])
			;
			board[row] |= (1 << col);
			crossRoads++;
			Road(board, row, col, "top right", ref crossRoads);
			Road(board, row, col, "top left", ref crossRoads);
			Road(board, row, col, "bottom right", ref crossRoads);
			Road(board, row, col, "bottom left", ref crossRoads);
		}
		while(true);
		foreach(int num in board)
		{
			Console.WriteLine((uint)num);
		}
		Console.WriteLine(crossRoads);
	}

	static void Road(int[] board, int row, int col, string direction, ref int crossRoads)
	{
		switch(direction)
		{
			case "top right": row -= 1; col += 1; break;
			case "top left": row -= 1; col -= 1; break;
			case "bottom right": row += 1; col += 1; break;
			case "bottom left": row += 1; col -= 1; break;
		}
		while(Valid(row, col))
		{
			if(((board[row] >> col) & 1) == 1)
			{
				crossRoads++;
			}
			board[row] |= (1 << col);
			switch(direction)
			{
				case "top right": row -= 1; col += 1; break;
				case "top left": row -= 1; col -= 1; break;
				case "bottom right": row += 1; col += 1; break;
				case "bottom left": row += 1; col -= 1; break;
			}
		}
	}

	static bool Valid(int row, int col)
	{
		bool
			isRowValid = 0 <= row && row < size,
			isColValid = 0 <= col && col < size
		;
		return isRowValid && isColValid;
	}
}