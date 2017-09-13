using System;

class MagicStrings
{
	static void Main()
	{
		int 
			diff = int.Parse(Console.ReadLine()),
			count = 0
		;
		char[] letters = {'k', 'n', 'p', 's'};

		for(int char0 = 0; char0 < letters.Length; char0++)
		{
			for(int char1 = 0; char1 < letters.Length; char1++)
			{
				for(int char2 = 0; char2 < letters.Length; char2++)
				{
					for(int char3 = 0; char3 < letters.Length; char3++)
					{
						string left = "" + letters[char0] + letters[char1] + letters[char2] + letters[char3];
						int weightLeft = CalcWeight(left);
						for(int char4 = 0; char4 < letters.Length; char4++)
						{
							for(int char5 = 0; char5 < letters.Length; char5++)
							{
								for(int char6 = 0; char6 < letters.Length; char6++)
								{
									for(int char7 = 0; char7 < letters.Length; char7++)
									{
										string right = "" + letters[char4] + letters[char5] + letters[char6] + letters[char7];
										int weightRight = CalcWeight(right);
										if(Math.Abs(weightLeft - weightRight) == diff)
										{
											Console.WriteLine("" + left + right);
											count++;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		if(count == 0)
		{
			Console.WriteLine("No.");
		}
	}

	private static int CalcWeight(string str)
	{
		int weight = 0;
		foreach(char ch in str)
		{
			switch(ch)
			{
				case 's': weight += 3; break;
				case 'n': weight += 4; break;
				case 'k': weight += 1; break;
				case 'p': weight += 5; break;
			}
		}
		return weight;
	}
}