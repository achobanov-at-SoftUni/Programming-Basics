using System;

class TextModification
{
	static void Main()
	{
		string 
			input = Console.ReadLine(),
			result = ""
		;
		char[] chars = input.ToCharArray();
		for(int i = 0, n = input.Length; i < n; i++)
		{
			if(chars[i] % 3 == 0)
			{
				chars[i] = Char.ToUpper(chars[i]);
			}
		}
		result = new string(chars);
		Console.WriteLine(result);
	}
}