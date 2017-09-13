using System;
using System.Linq;

class Numerology
{
	static void Main()
	{
		string[] input = Console.ReadLine().Split(' ');
		string username = input[1];
		int[] date = input[0].Split('.').Select(a => int.Parse(a)).ToArray();
		long celNum = 0;
		celNum += date[0] * date[1] * date[2];
		if(date[1] % 2 != 0)
		{
			celNum *= celNum;
		}
		for(int i = 0, n = username.Length; i < n; i++)
		{
			if(username[i] > 47 && username[i] < 58)
			{
				celNum += username[i] - '0';
			}
			else if(username[i] > 64 && username[i] < 91)
			{
				celNum += (username[i] - 'A' + 1) * 2;
			}
			else
			{
				celNum += username[i] - 'a' + 1;
			}
		}
		while(celNum > 13)
		{
			string digitsString = Convert.ToString(celNum);
			int[] digits = digitsString.Select(a => Convert.ToInt32(a) - 48).ToArray();
			celNum = 0; 
			for(int i = 0, n = digits.Length; i < n; i++)
			{
				celNum += digits[i];
			}
		}
		Console.WriteLine(celNum);	
	}
}