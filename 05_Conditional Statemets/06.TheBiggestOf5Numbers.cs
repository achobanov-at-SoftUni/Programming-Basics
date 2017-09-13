using System;

class TheBiggestOf5Numbers
{
	static void Main()
	{
		float
			a = float.Parse(Console.ReadLine()),
			b = float.Parse(Console.ReadLine()),
			c = float.Parse(Console.ReadLine()),
			d = float.Parse(Console.ReadLine()),
			e = float.Parse(Console.ReadLine())
		;
		if(a >= b && a >= c && a >= d && a >= e)
		{
			Console.WriteLine(a);
		}
		else if(b >= a && b >= c && b >= d && b >= e)
		{
			Console.WriteLine(b);
		}
		else if(c >= a && c >= b && c >= d && c >= e)
		{
			Console.WriteLine(c);
		}
		else if(d >= a && d >= b && d >= c && d >= e)
		{
			Console.WriteLine(d);
		}
		else if(e >= a && e >= b && e >= c && e >= d)
		{
			Console.WriteLine(e);
		}
	}
}