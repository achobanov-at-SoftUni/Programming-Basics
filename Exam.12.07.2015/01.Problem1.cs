using System;

class Problem1
{
	static void Main()
	{
		double fieldGoals = double.Parse(Console.ReadLine());
		double fieldGoalAttempts = double.Parse(Console.ReadLine());
		double pointFieldGoals = double.Parse(Console.ReadLine());
		double turnovers = double.Parse(Console.ReadLine());
		double offensiveRebounds = double.Parse(Console.ReadLine());
		double OpDefensiveRebounds = double.Parse(Console.ReadLine());
		double freeThrows = double.Parse(Console.ReadLine());
		double freeThrowAttempts = double.Parse(Console.ReadLine());

		double eFG = (fieldGoals + 0.5 * pointFieldGoals) / fieldGoalAttempts;
		double TOV = turnovers / (fieldGoalAttempts + 0.44 * freeThrowAttempts + turnovers);
		double ORB = offensiveRebounds / (offensiveRebounds + OpDefensiveRebounds);
		double FT = freeThrows / fieldGoalAttempts;

		Console.WriteLine("eFG% {0:F3}\nTOV% {1:F3}\nORB% {2:F3}\nFT% {3:F3}\n", eFG, TOV, ORB, FT);
	}
}