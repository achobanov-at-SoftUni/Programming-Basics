using System;

class Sort3NumbersWithNestedIfs
{
	static void Main()
	{
		float
			a = float.Parse(Console.ReadLine()),
			b = float.Parse(Console.ReadLine()),
			c = float.Parse(Console.ReadLine())
		;
		if((a == b && a > c) || (a > b && b > c) || (a > b && b == c) || (a == b && b == c))
		{
			Console.WriteLine("{0} {1} {2}", a, b, c);
		}
		else if((a == c && a > b) || (a > c && c > b) || (a > c && c == b))
		{
			Console.WriteLine("{0} {1} {2}", a, c, b);
		}
		else if((b > a && a > c) || b > a && a == c)
		{
			Console.WriteLine("{0} {1} {2}", b, a, c);
		}
		else if((b > c && c > a))
		{
			Console.WriteLine("{0} {1} {2}", b, c, a);
		}
		else if((c > b && b > a) || (c > b && b == a))
		{
			Console.WriteLine("{0} {1} {2}", c, b, a);
		}
		else if(c > a && a > b)
		{
			Console.WriteLine("{0} {1} {2}", c, a, b);
		}
	}
}