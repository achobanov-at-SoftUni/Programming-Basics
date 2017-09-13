using System;

class PeterSGame
{
	static void Main()
	{
		ulong
			startNum = ulong.Parse(Console.ReadLine()),
			endNum = ulong.Parse(Console.ReadLine());
		decimal sum = 0;
		string 
			replace = Console.ReadLine(),
			holder = "",
			output = "";
		int numToReplace;
		for(ulong i = startNum; i < endNum; ++i)
		{
			if(i % 5 == 0)
			{
				sum += i;
			}
			else
			{
				sum += i % 5;
			}
		}
		holder = Convert.ToString(sum);
		if(sum % 2 == 0)
		{
			numToReplace = holder[0];
		}
		else
		{
			numToReplace = holder[holder.Length - 1];
		}
		for(int i = 0, n = holder.Length; i < n; ++i)
		{
			if(holder[i] == numToReplace)
			{
				output += replace;
			}
			else
			{
				output += holder[i];
			}
		}
		Console.WriteLine(output);
	}
}