using System;

class Problem2
{
	static void Main()
	{
		string keyword = Console.ReadLine();
		string message = Console.ReadLine();
		int sumKey = 0;
		for(int i = 0, n = keyword.Length; i < n; i++)
		{
			sumKey += keyword[i];
		}
		while(sumKey > 9)
		{
			string sumLength = Convert.ToString(sumKey);
			sumKey = 0;
			for(int i = 0, n = sumLength.Length; i < n; i++)
			{
				sumKey += sumLength[i] - 48;
			}
		}
		char[] symbols = new char[message.Length];
		for(int i = 0, n = message.Length; i < n; i++)
		{
			int numValue = 0;
			if(message[i] % sumKey == 0)
			{
				numValue = message[i] + sumKey;
			}
			else
			{
				numValue = message[i] - sumKey;
			}
			symbols[i] = Convert.ToChar(numValue);
		}
		Array.Reverse(symbols);
		string decrypted = new string(symbols);
		Console.WriteLine(decrypted);
	}
}