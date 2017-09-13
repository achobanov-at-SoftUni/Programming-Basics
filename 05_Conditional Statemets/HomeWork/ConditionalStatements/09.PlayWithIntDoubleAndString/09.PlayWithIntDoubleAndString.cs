using System;

class PlayWithIntDoubleOrString
{
	static void Main()
	{
		//Instructions for the user
		Console.WriteLine
		(
@"Please choose a type:
1 --> int
2 --> double
3 --> string"
		);
		//Variable to store user choice
		int varType = int.Parse(Console.ReadLine());
		switch(varType)
		{
			case 1: 
				Console.WriteLine("Please enter an int: ");
				int number = int.Parse(Console.ReadLine()) + 1; 
				Console.WriteLine(number);
				break;
			case 2:
				Console.WriteLine("Please enter a double: ");
				double realNumber = double.Parse(Console.ReadLine()) + 1;
				Console.WriteLine(realNumber);
				break;
			case 3:
				Console.WriteLine("Please enter a string: ");
				string chars = Console.ReadLine() + '*';
				Console.WriteLine(chars);
				break;
		}
	}
}