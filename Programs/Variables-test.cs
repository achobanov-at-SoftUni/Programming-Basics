using System;

class MainClass
{
	static void Main (string[] args)
	{
		int? num = null;
		Console.WriteLine(num);

		num += 42;
		Console.WriteLine(num);

		num = 10;
		Console.WriteLine(num);	

	}
}
