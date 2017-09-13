using System;

class QuadraticEquation
{
	static void Main()
	{
		double
			a = double.Parse(Console.ReadLine()),
			b = double.Parse(Console.ReadLine()),
			c = double.Parse(Console.ReadLine()),
			D = b * b - 4 * a * c,
			x1 = (-b + Math.Sqrt(D)) / (2 * a),
			x2 = (-b - Math.Sqrt(D)) / (2 * a)
		;
		if(D < 0)
		{
			Console.WriteLine("No real roots.");
		}
		else if(D == 0)
		{
			Console.WriteLine("x1 = x2 = {0}", x1);
		}
		else
		{
			Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
		}
	}
}