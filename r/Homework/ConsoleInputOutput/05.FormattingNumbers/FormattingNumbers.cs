using System;

class FormatingNumbers
{
	static void Main()
	{
		int a = int.Parse(Console.ReadLine());
		double 
			b = double.Parse(Console.ReadLine()),
			c = double.Parse(Console.ReadLine())
				;
		Console.WriteLine
			(
				"{0,-10:X} {1} {2,10:F2} {3,-10:F3}", 
				a, Convert.ToString(a, 2).PadLeft(10,'0'), b, c
			);
	}
}