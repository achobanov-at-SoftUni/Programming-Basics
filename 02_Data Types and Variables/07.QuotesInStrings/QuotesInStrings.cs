using System;

class QuotesInStrings
{
	static void Main()
	{
		string 
			a = "The \"use\" of quotation marks causes difficulties.", 
			b = @"The ""use"" of quotation marks causes difficulties."
		;
		Console.WriteLine(a + "\n" + b);
	}
}