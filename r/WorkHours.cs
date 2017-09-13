using System;

class WorkHours
{
	static void Main()
	{
		int 
			requiredWorkHours = int.Parse(Console.ReadLine()),
			availableDays = int.Parse(Console.ReadLine()),
			availableHours = availableDays * 12,
			bikingHours = 10 * availableHours / 100,
			productivityPercent = int.Parse(Console.ReadLine()),
			workingHours = productivityPercent * (availableHours - bikingHours) / 100
		;
		if(requiredWorkHours <= workingHours)
		{
			Console.WriteLine("Yes" + "\n" + "{0}", workingHours - requiredWorkHours);
		}
		else
		{
			Console.WriteLine("No" + "\n" + "{0}", workingHours - requiredWorkHours);
		}
	}
}