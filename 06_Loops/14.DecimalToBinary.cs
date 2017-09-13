using System;

class DecToBinNum
{
	static void Main()
	{
		long input = long.Parse(Console.ReadLine());
		if(input == 0)
		{
			Console.WriteLine(0);
			return;
		}
		string bin = "";
		for(; input != 0; input /= 2)
		{
			bin += (input % 2);
		}
		Console.WriteLine(Reverse(bin));
	}

	static string Reverse(string input)
	{
		char[] arr = input.ToCharArray();
		Array.Reverse(arr);
		return new string (arr);
	}
}