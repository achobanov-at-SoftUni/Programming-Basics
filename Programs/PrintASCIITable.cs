using System;

class PrintASCII
{
	static void Main()
	{
		for(int i = 0; i < 255; i++)
		{
			char symbol = Convert.ToChar(i);
			Console.WriteLine(symbol);
		}
	}
}