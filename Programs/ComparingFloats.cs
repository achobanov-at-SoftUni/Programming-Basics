using System;

class ComparingFloats
{
	static void Main()
	{
		double 
			a = double.Parse(Console.ReadLine()), 
			b = double.Parse(Console.ReadLine()),
			eps = 0.000001,
			n = a - b
		;

		if((n > 0 && n < eps) | (n < 0 && n > -eps))
		{
			Console.WriteLine("Numbers A and B are \"equal\". The difference of " + n + " is not relevant.");
		}
		else
		{
			Console.WriteLine("A and B are not \"equal\". A difference of " + n + " is too big");
		}
	}
}