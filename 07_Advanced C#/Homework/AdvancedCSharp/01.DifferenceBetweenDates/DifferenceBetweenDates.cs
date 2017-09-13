using System;

class DifferenceBetweenDates
{
	static void Main()
	{
		string
			a = Console.ReadLine(),
			b = Console.ReadLine(),
			format = "d.MM.yyyy"
		;
		DateTime
			start = DateTime.ParseExact(a, format, null),
			end = DateTime.ParseExact(b, format, null)
		;
		Console.WriteLine((end - start).TotalDays);
	}
}