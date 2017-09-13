using System;

class MoonGravity
{
	static void Main()
	{
		float 
			weight = float.Parse(Console.ReadLine()),
			moonWeight = weight * 0.17f
		;
		Console.WriteLine("{0:F3}", moonWeight);
	}
}