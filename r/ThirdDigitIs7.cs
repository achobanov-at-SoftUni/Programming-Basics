using System;

class ThirdDigitIs7
{
	static void Main()
	{
		int 
			number = int.Parse(Console.ReadLine()),
			count = 0
		;
		string split = Convert.ToString(number);
		char[] sequence = split.ToCharArray();
		for(int i = 0, n = sequence.Length; i < n; i++)
		{
			int check = sequence[i] - '0';
			if(check == 7 && i == n - 3)
			{
				Console.WriteLine("true");
				count++;
			}
		}
		if(count == 0)
		{
			Console.WriteLine("false");
		}
	}
}