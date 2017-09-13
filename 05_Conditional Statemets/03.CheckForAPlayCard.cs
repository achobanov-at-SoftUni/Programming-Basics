using System;

class CheckForAPlayCard
{
	static void Main()
	{
		string input = Console.ReadLine();
		int number;
		bool check = int.TryParse(input, out number);
		if(input == "J" || input == "Q" || input == "K" || input == "A")
		{
			Console.WriteLine("yes");
		}
		else if(check == true && (number > 1 && number < 11))
		{
			Console.WriteLine("yes");
		}
		else
		{
			Console.WriteLine("no");
		}
	}
}