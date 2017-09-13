using System;

class DecToHexNum
{
	static void Main()
	{
		long input = long.Parse(Console.ReadLine());
		string hex = "";
		for(; input != 0; input /= 16)
		{
			switch(input % 16)
			{
				case 10: hex += "A"; break;
				case 11: hex += "B"; break;
				case 12: hex += "C"; break;
				case 13: hex += "D"; break;
				case 14: hex += "E"; break;
				case 15: hex += "F"; break;
				default: hex += input % 16; break; 
			}
		}
		Console.WriteLine(Reverse(hex));
	}

	static string Reverse(string input)
	{
		char[] arr = input.ToCharArray();
		Array.Reverse(arr);
		return new string (arr);
	}
}