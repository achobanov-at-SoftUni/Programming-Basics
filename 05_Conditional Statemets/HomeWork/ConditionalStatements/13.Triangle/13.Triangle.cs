using System;

class Triangle
{
	static void Main()
	{
		int
			xa = int.Parse(Console.ReadLine()),
			ya = int.Parse(Console.ReadLine()),
			xb = int.Parse(Console.ReadLine()),
			yb = int.Parse(Console.ReadLine()),
			xc = int.Parse(Console.ReadLine()),
			yc = int.Parse(Console.ReadLine())
		;
		// Math formulas
		double
			lineA = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya)),
			lineB = Math.Sqrt((xc - xb) * (xc - xb) + (yc - yb) * (yc - yb)),
			lineC = Math.Sqrt((xa - xc) * (xa - xc) + (ya - yc) * (ya - yc)),
			halfPerimeter = (lineA + lineB + lineC) / 2,
			area = Math.Sqrt(halfPerimeter * (halfPerimeter - lineA) * (halfPerimeter - lineB) * (halfPerimeter - lineC))
		;
		// Triangle inequalities.
		if(lineA + lineB > lineC && lineA + lineC > lineB && lineB + lineC > lineA)
		{
			Console.WriteLine("Yes\n{0:F2}", area);
		}
		else
		{
			Console.WriteLine("No\n{0:F2}", lineA);
		}
	}
}