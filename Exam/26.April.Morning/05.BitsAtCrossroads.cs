using System;
using System.Collections.Generic;
using System.Linq;

class  BitsAtCrossroaods
{
	static void Main()
	{
		int 
			boardLength = int.Parse(Console.ReadLine()),
			crossroads = 0,
			crossroadsCount = 0
		;
		int[] board = new int[boardLength];
		List<int> 
			lines = new List<int>(),
			positions = new List<int>()
		;
		while(true)
		{
			string input = Console.ReadLine();
			if(input == "end")
			{
				break;
			}
			int[] holder = input.Split(' ').Select(a => int.Parse(a)).ToArray();
			lines.Add(holder[0]);
			positions.Add(holder[1]);
			if(holder[0] == 0 || holder[1] == 0 || 
				holder[0] == boardLength - 1 || holder[1] == boardLength - 1)
			{
				crossroadsCount++;
			}
			crossroads++;
		}
		for(int i = 0; crossroads != 0; i++, crossroads--)
		{
			if(Valid(lines[i], positions[i], boardLength))
			{
				board[lines[i]] |= (1 << positions[i]);
				for(int y = lines[i] - 1, a = positions[i] + 1; a < boardLength && y >= 0; y--, a++)
				{
					board[y] |= (1 << a);
				}
				for(int y = lines[i] - 1, a = positions[i] - 1; a >= 0 && y >= 0; y--, a--)
				{
					board[y] |= (1 << a);
				}
				for(int y = lines[i] + 1, a = positions[i] + 1;	a < boardLength && y < boardLength; y++, a++)
				{
					board[y] |= (1 << a);
				}
				for(int y = lines[i] + 1, a = positions[i] - 1; a >= 0 && y < boardLength; y++, a--)
				{
					board[y] |= (1 << a);
				}
			}
		}
		for(int line = 1; line < boardLength - 1; line++)
		{
			for(int pos = boardLength - 2; pos >= 1; pos--)
			{
				if(Valid(line, pos, boardLength))
				{
					if((((board[line] >> pos) & 1) == 1) &&
						(((board[line - 1] >> pos - 1) & 1) == 1) && 
						(((board[line - 1] >> pos + 1) & 1) == 1) &&
						(((board[line + 1] >> pos - 1) & 1) == 1) && 
						(((board[line + 1] >> pos + 1) & 1) == 1))
					{
						crossroadsCount++;
					}
				}
			}
		}
		foreach(var num in board)
		{
			Console.WriteLine(num);
		}
		Console.WriteLine(crossroadsCount);
	}

	static bool Valid(int line, int position, int size)
	{
		bool
			isLineValid = 0 <= line && line < size,
			isPositionValid = 0 <= position && position < size
		;
		return isLineValid && isPositionValid;
	}
}