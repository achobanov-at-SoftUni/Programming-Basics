using System;

class WTF
{
	static void Main()
	{
		Random rng = new Random();
		int 
			a = 0,
			b = 5
		;
		Console.WriteLine("A = {0}\nB = {1}", a, b);
		a = a + b;
		b = a - b;
		a = a - b;
		// var temp = a;
		// a = b;
		// b = temp;
		Console.WriteLine("A = {0}\nB = {1}", a, b);
	}
}