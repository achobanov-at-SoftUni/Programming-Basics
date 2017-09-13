using System;

class JoroTheFootballPlayer
{
	static void Main()
	{
		string 
			leap = Console.ReadLine(),
			holidays = Console.ReadLine(),
			hometownSpent = Console.ReadLine()
		;

		float 
			p = float.Parse(holidays), 
			h = float.Parse(hometownSpent), 
			footballPlayed
		;

		if(leap == "t")
		{
			footballPlayed = p / 2 + 2 * (52 - h) / 3 + h + 3;
		}
		else
		{
			footballPlayed = p / 2 + 2 * (52 - h) /3 + h;
		}

		Console.WriteLine((int)footballPlayed);
	}
}

