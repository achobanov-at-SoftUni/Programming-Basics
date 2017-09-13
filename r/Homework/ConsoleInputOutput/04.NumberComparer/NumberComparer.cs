using System;

class NumberComparer
{
	static void Main()
	{
		float 
			a = float.Parse(Console.ReadLine()),
			b = float.Parse(Console.ReadLine())
		;
		Console.WriteLine(Math.Max(a, b));
	}
}