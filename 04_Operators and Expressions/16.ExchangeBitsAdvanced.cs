using System;

class ExchangeBitsAdvanced
{
	static void Main()
	{
		int 
			number = int.Parse(Console.ReadLine()),
			p = int.Parse(Console.ReadLine()),
			q = int.Parse(Console.ReadLine()),
			k = int.Parse(Console.ReadLine()),
			maskP = ~(1 << p + k),
			maskQ = ~(1 << q + k),
			bitsP = (number >> p) & maskP,
			bitsQ = (number >> q) & maskQ
		;
		Console.WriteLine(Convert.ToString(maskP, 2));
		//number = number  
	}
}