using System;

class TravelerBob
{
	static void Main()
	{
		string year = Console.ReadLine();
		int contractMonths = int.Parse(Console.ReadLine());
		int familyMoths = int.Parse(Console.ReadLine());
		int normalMonths = 12 - (familyMoths + contractMonths);
		int contractFlights = contractMonths * 12;
		int familyFlights = familyMoths * 4;
		double normalFlights = normalMonths * 0.6 * 12;
		double totalFlights = contractFlights + familyFlights + normalFlights;
		if(year == "leap")
		{
			totalFlights += 0.05 * totalFlights;
		}
		Console.WriteLine((int)totalFlights);
	}
}