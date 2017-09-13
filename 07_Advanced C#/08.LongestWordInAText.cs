using System;

class LongestWordInAText
{
	static void Main()
	{
		string[] input = Console.ReadLine().Split(' ');
		int 
			longestWord = 0,
			index = 0
		;
		for(int i = 0, n = input.Length; i < n; i++)
		{
			int wordLength = input[i].Length;
			if(wordLength > longestWord)
			{
				longestWord = wordLength;
				index = i;
			}
		}
		input[index] = RemoveDot(input[index]);
		Console.WriteLine(input[index]);
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