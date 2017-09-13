using System;

class CirclePerimeterAndArea
{
	static void Main()
	{
		int r = int.Parse(Console.ReadLine());
		float 
			p = 3.14f,
			P = 2 * r * p,
			S = p * r * r
		;
		Console.WriteLine("Perimeter: {0:F2}; Area: {1:F2}", P, S);
	}
}