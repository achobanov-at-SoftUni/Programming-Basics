using System;
using System.Collections.Generic;

class MagicDates
{
	static void Main()
	{
		int
			startYear = int.Parse(Console.ReadLine()),
			endYear = int.Parse(Console.ReadLine()),
			magicWeight = int.Parse(Console.ReadLine()),
			dateWeight = 0,
			days = 0,
			counter = 0
		;
		// Loops for years.
		for(int year = startYear; year <= endYear; year++)
		{
			// Loops for months.
			for(int month = 1; month <= 12; month++)
			{	
				// Estimates how many days does this month have.
				if((month < 8 && month % 2 == 1) || (month > 7 && month % 2== 0))
				{
					days = 31;
				}
				else if(month == 2 && year % 4 == 0)
				{
					days = 29;
				}
				else if(month == 2 && year % 4 != 0)
				{
					days = 28;
				}
				else
				{
					days = 30;
				}
				// Loops for days.
				for(int day = 1; day <= days; day++)
				{
					// Storing day, month and year as arrays containing single digits in order to 
					// apply the formula.
					int[] 
					a = ToArray(day),
					b = ToArray(month),
					c = ToArray(year)
						;
					dateWeight =  
						a[0] * a[1] + a[0] * b[0] + a[0] * b[1] + a[0] * c[0] + a[0] * c[1] + a[0] * c[2] + a[0] * c[3] +
						a[1] * b[0] + a[1] * b[1] + a[1] * c[0] + a[1] * c[1] + a[1] * c[2] + a[1] * c[3] +
						b[0] * b[1] + b[0] * c[0] + b[0] * c[1] + b[0] * c[2] + b[0] * c[3] +
						b[1] * c[0] + b[1] * c[1] + b[1] * c[2] + b[1] * c[3] +
						c[0] * c[1] + c[0] * c[2] + c[0] * c[3] +
						c[1] * c[2] + c[1] * c[3] +
						c[2] * c[3]
						;
					// Standard issue check. 'counter' is used to print "No" if no matches are found.
					if(dateWeight == magicWeight)
					{
						Console.WriteLine("{0}{1}-{2}{3}-{4}{5}{6}{7}", a[0], a[1], b[0], b[1], c[0], c[1], c[2], c[3]);
						counter++;
					}
				}
			}
		}
		if(counter == 0)
		{
			Console.WriteLine("No");
		}
	}
	// Method that takes number converts it to array of single digits.
	static int[] ToArray(int a)
	{
		// Defining list to store our digits.
		var digits = new List<int>();
		// Loops for each individual digit in the number and stores them inside our list.
		for(int n = a; n != 0; n /= 10)
		{
			// This adds '0' digit in front of digits less then 10. I know it is not 
			// actually necessary, but the code looks more structured this way.
			if(a <= 9)
			{
				digits.Add(0);
			}
			digits.Add(n % 10);
		}
		// Creates our array.
		var arr = digits.ToArray();
		// Inverts if digit is bigger then 9
		if(a > 9)
		{
			Array.Reverse(arr);
		}
		return arr;
	}
}