using System;

class ExtractURLsFromText
{
	static void Main()
	{
		string[] input = Console.ReadLine().Split(' ');
		for(int i = 0, n = input.Length; i < n; i++)
		{
			if((input[i][0] == 'h' && input[i][1] == 't') || 
				(input[i][0] == 'w' && input[i][1] == 'w'))
			{
				input[i] = RemoveDot(input[i]);
				Console.WriteLine(input[i]);
			}
		}
	}

	static string RemoveDot(string word)
	{
		int last = word.Length - 1;
		if(word[last] != '.')
		{
			return word;
		}
		word = word.Remove(word.Length - 1);
		return word;
	}
}