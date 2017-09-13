using System;

class RemovingNames
{
	static void Main()
	{
		string[] 
			names = Console.ReadLine().Split(' '),
			namesToRemove = Console.ReadLine().Split(' '),
			output = new string[names.Length - namesToRemove.Length]
		;
		for(int name = 0, n = names.Length, counter = 0; name < n; name++)
		{
			if(Array.IndexOf(namesToRemove, names[name]) == - 1)
			{
				output[counter] = names[name];
				counter++;
			}
		}
		for(int i = 0, n = output.Length; i < n; i++)
		{
			Console.WriteLine(output[i] + " ");
		}
		Console.WriteLine();
	}
}