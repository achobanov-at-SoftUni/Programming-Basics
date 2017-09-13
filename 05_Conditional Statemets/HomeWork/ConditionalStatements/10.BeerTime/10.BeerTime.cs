using System;

class BeerTime
{
	static void Main()
	{
		string 
			beerStart = "1:00 PM",
			beerEnd = "3:00 AM"
		;
		DateTime
			beerTimeStart = DateTime.Parse("1:00 PM"),
			beerTimeEnd = DateTime.Parse("3:00 AM"),
			time = DateTime.Parse(Console.ReadLine())
		;
		if(time >= beerTimeStart || time <= beerTimeEnd)
		{
			Console.WriteLine("beer time");
		}
		else
		{
			Console.WriteLine("non-beer time");
		}
	}
}