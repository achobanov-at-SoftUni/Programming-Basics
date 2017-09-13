using System;

class Rectangles
{
	static void Main()
	{
		float
			width = float.Parse(Console.ReadLine()),
			height = float.Parse(Console.ReadLine()),
			perimenter = 2 * width + 2 * height,
			area = width * height
		;
		Console.WriteLine("Perimenter = {0}, Area = {1}", perimenter, area);
	}
}