using System;

class MultiplicatoinSign
{
	static void Main()
	{
		float
			a = float.Parse(Console.ReadLine()),
			b = float.Parse(Console.ReadLine()),
			c = float.Parse(Console.ReadLine())
		;
		if(a == 0 || b == 0 || c == 0)
			Console.WriteLine("0");
		else if(a > 0)
			if(b > 0)
				if(c > 0)
					Console.WriteLine("+");
				else
					Console.WriteLine("-");
			else
				if(c > 0)
					Console.WriteLine("-");
				else
					Console.WriteLine("+");
		else
			if(b > 0)
				if(c > 0)
					Console.WriteLine("-");
				else 
					Console.WriteLine("+");
			else
				if(c > 0)
					Console.WriteLine("+");
				else
					Console.WriteLine("-");
	}
}
