using System;
using System.Linq;

class Problem4
{
	static void Main()
	{
		int rooms = int.Parse(Console.ReadLine());
		string statusData = Console.ReadLine();
		string[] roomStatus = new String[rooms];
		for(int i = 0, y = 0; i < rooms; i++)
		{
			if(y == statusData.Length)
			{
				y = 0;
			}
			roomStatus[i] = Convert.ToString(statusData[y]);
			y++;
		}
		string command = Console.ReadLine();
		int currentRoom = rooms / 2;
		while(command != "END")
		{
			string[] commandData = command.Split(' ').ToArray();
			string direction = commandData[0];
			int toRoom = Convert.ToInt32(commandData[1]) + 1;
			int nextRoom;
			if(direction == "LEFT")
			{
				nextRoom = Math.Max(currentRoom - toRoom, 0);
			}
			else
			{
				nextRoom = Math.Min(currentRoom + toRoom, rooms - 1);
			}
			if(roomStatus[nextRoom] == "L")
			{
				roomStatus[nextRoom] = "D";
			}
			else
			{
				roomStatus[nextRoom] = "L";
			}
			currentRoom = nextRoom;
			command = Console.ReadLine();
		}
		int prayer = 'D';
		int darkRooms = 0;
		foreach(string status in roomStatus)
		{
			if(status == "D")
			{
				darkRooms += 1;
			}
		}
		Console.WriteLine(prayer * darkRooms);
	}
}
