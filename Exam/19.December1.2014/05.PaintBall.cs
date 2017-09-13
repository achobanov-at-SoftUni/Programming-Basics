using System;
using System.Linq;

class PaintBall
{
	static void Main()
	{
		int[] wall = {1023, 1023, 1023, 1023, 1023, 1023, 1023, 1023, 1023, 1023};
		string input = Console.ReadLine();
		int ammo = 0;
		while(input != "End")
		{
			string[] shotData = input.Split(' ').ToArray();
			int row = int.Parse(shotData[0]),
			    pos = int.Parse(shotData[1]),
			    rad = int.Parse(shotData[2]);
			for(int i = 0; i < 10; i++)
			{
				for(int bit = 9; bit >= 0; bit--)
				{
					int startRow = row - rad,
						endRow = row + rad,
						startPos = pos - rad,
						endPos = pos + rad;
					string shot = "";
					switch(ammo % 2)
					{
						case 0: shot = "black"; break;
						case 1: shot = "white"; break;
					}
					if(i >= startRow && i <= endRow && bit >= startPos && bit <= endPos)
					{
						if(shot == "black")
						{
							wall[i] &= ~(1 << bit);
						}
						else
						{
							wall[i] |= 1 << bit;
						}
					}
				}
			}
			ammo++;
			input = Console.ReadLine();
		}
		int sum = 0;
		foreach(int num in wall)
		{
			sum += num;
		}
		Console.WriteLine(sum);
	}
}