using System;
using System.Linq;

class BitLocker
{
	static void Main()
	{
		int[] rows = Console.ReadLine().Split(' ').Select(a => Convert.ToInt32(a)).ToArray();
		string command = Console.ReadLine();
		while(command != "end")
		{
			string[] commandData = command.Split(' ').ToArray();
			if(commandData[0] == "check")
			{
				int check = 0,
					col = int.Parse(commandData[1]);
				foreach(int row in rows)
				{
					check += (row >> col) & 1;
				}
				Console.WriteLine(check);
			}
			else
			{
				Roll(commandData, rows);
			}
			command = Console.ReadLine();
		}
		foreach(int num in rows)
		{
			Console.Write(num + " ");
		}
		Console.WriteLine();
	}
	// Rolls the bits in either direction
	static void Roll(string[] commands, int[] rows)
	{
		int row = int.Parse(commands[0]),
			rolls = int.Parse(commands[2]);
		string direction = commands[1];
		for(int i = 0; i < rolls; i++)
		{
			switch(direction)
			{
				case "right":
					int rightmostBitValue = rows[row] & 1;
					rows[row] >>= 1;
					rows[row] |= (rightmostBitValue << 11);
					break;
				case "left":
					int leftmostBitValue = rows[row] >> 11 & 1;
					rows[row] <<= 1;
					// Very important line - it clears the 12th bit after the rolling. Easy to miss.
					rows[row] &= ~(1 << 12);
					rows[row] |= leftmostBitValue;
					break;
			}
		}
	}
}