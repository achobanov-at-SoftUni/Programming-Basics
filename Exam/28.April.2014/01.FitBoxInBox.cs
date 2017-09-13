using System;

class FitBoxInBox
{
	static void Main()
	{
		int
			w = int.Parse(Console.ReadLine()),
			h = int.Parse(Console.ReadLine()),
			d = int.Parse(Console.ReadLine()),
			a = int.Parse(Console.ReadLine()),
			b = int.Parse(Console.ReadLine()),
			c = int.Parse(Console.ReadLine())
		;
		Fit(w, h, d, a, b, c);
		Fit(w, h, d, a, c, b);
		Fit(w, h, d, b, a, c);
		Fit(w, h, d, b, c, a);
		Fit(w, h, d, c, a, b);
		Fit(w, h, d, c, b, a);

		Fit(a, b, c, w, h, d);
		Fit(a, b, c, w, d, h);
		Fit(a, b, c, h, w, d);
		Fit(a, b, c, h, d, w);
		Fit(a, b, c, d, w, h);
		Fit(a, b, c, d, h, w);
	}

	static void Fit(int w, int h, int d, int a, int b, int c)
	{
		if(w < a && h < b && d < c)
		{
			Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", w, h, d, a, b, c);
		}
	}
}