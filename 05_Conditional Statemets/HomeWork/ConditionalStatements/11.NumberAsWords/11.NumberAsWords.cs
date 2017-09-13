using System;
using System.Text;

class NumberAsWords
{
	static void Main()
	{
		int number = int.Parse(Console.ReadLine());
		Console.WriteLine(NumToWords(number));
	}
	// Method that takes a number as input and returns the same number in string of words.
	static string NumToWords(int number)
	{
		string words = "";
		if(number == 0)
		{
			return "Zero";
		}
		// Checking for hundreds.
		if(number / 100 > 0)
		{
			// Calling the method from inside gets the number of the hundreds.
			// NumToWords(number / 100) simply executes lines 31 to 38, including, 
			// thus converting the first digit into the appropriete word.
			words += NumToWords(number / 100) + "hundred" + " ";
			// Using '%' we allow our program to execute lines 42+, thus getting
			// the word for the ten-ths.
			number %= 100;
		}
		if(number > 0)
		{
			if(words != "")
			{
				words += "and" + " ";
			}
			if(number < 20)
			{
				// Declaring variable array that holds the appropriate words for numbers 1 to 19.
				// As stated the "irrelevent" word is actually irrelevent since it can't be accessed,
				// due to the logic of the method. But it needs to be there in order for the program
				// to access the appropriate word.
				var teens = new[] {"irrelevent", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
				words += teens[number] + " ";
				// with these 3 lines of code we are capitalizing the First character in the string
				// according to the English grammar ^^.
				StringBuilder capitalize = new StringBuilder(words);
				capitalize[0] = Char.ToUpper(words[0]);
				words = capitalize.ToString();
				// Returns string and exites the method
				return words;
			}
			else
			{
				//Same as above
				var tens = new[] {"irrelevent", "irrelevent", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};
				words += tens[number / 10] + " ";
				// This conditional statement checks if this is the first word in the string. If yes -
				// capitalizes it.
				if(words == tens[number / 10] + " ")
				{
					StringBuilder capitalize = new StringBuilder(words);
					capitalize[0] = Char.ToUpper(words[0]);
					words = capitalize.ToString();
				}	
			}
			// Same. Single digits
			var digits = new[] {"irrelevent", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
			words += digits[number % 10] + " ";
		}
		return words;
	}
}