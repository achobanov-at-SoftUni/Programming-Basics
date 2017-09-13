using System;

class TheBiggestof3Numbers
{
	static void Main()
	{
		float 
			a = float.Parse(Console.ReadLine()),
			b = float.Parse(Console.ReadLine()),
			c = float.Parse(Console.ReadLine())
		;
		if(a >= b && a >= c)
		{
			Console.WriteLine(a);
		}
		else if(b >= a && b >= c)
		{
			Console.WriteLine(b);
		}
		else if(c >= b && c >= a)
		{
			Console.WriteLine(c);
		}
	}
}