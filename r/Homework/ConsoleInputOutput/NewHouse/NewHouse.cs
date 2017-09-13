using System;

class NewHouse
{
	static void Main()
	{
		int height = int.Parse(Console.ReadLine());
		string roof = "*";
		for(int i = 1; roof.Length < height; i += 2)
		{	
			roof = new String('*', i);
			int paddingNumber = (height - i) / 2;
			string padding = new String('-', paddingNumber);
			Console.WriteLine("{0} {1} {2}", padding, roof, padding);
		}
		for(int i = 0; i < height; i++)
		{
			char wall = '|';
			string houseWidth = new String('*', height - 2);
			Console.WriteLine("{0} {1} {2}", wall, houseWidth, wall);
		}
	}
}