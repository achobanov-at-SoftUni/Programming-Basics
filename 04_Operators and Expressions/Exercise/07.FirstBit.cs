using System;

class FirstBti
{
	static void Main()
	{
		int input = int.Parse(Console.ReadLine());
		int position = 1;
		int bit = (input >> position) & 1;
		Console.WriteLine(bit);
	}
}