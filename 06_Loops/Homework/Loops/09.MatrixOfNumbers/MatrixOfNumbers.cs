using System;

class MatrixOfNumbers
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		for(int i = 0; i < n; i++)
		{
			for(int y = i + 1; y <= n + i; y++)
			{
				Console.Write(y + " ");
			}
			Console.WriteLine("");
		}	
	}
}