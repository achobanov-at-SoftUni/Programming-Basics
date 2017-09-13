using System;

class BonusScore
{
	static void Main()
	{
		int score = int.Parse(Console.ReadLine());
		if(score <= 0 || score > 9)
		{
			Console.WriteLine("Invalid score");
			return;
		}
		else if(score < 4)
			score *= 10;
		else if(score < 7)
			score *= 100;
		else
			score *= 1000;
		Console.WriteLine(score);
	}

}