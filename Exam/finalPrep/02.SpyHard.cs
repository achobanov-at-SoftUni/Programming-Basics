using System;

class SpyHard
{
	static void Main()
	{
		int key = int.Parse(Console.ReadLine());
		string message = Console.ReadLine();
		int symbolsSum = 0;
		for(int i = 0, n = message.Length; i < n; i++)
		{
			//char symbol = Convert.ToChar(message[i]);
			if(message[i] > 64 && message[i] < 91)
			{
				symbolsSum += message[i] - 64;
			}
			else if(message[i] > 96 && message[i] < 123)
			{
				symbolsSum += message[i] - 96;	
			}
			else
			{
				symbolsSum += message[i];
			}
		}
		Console.WriteLine("{0}{1}{2}", key, message.Length, DecimalToArbitrarySystem((int)symbolsSum, key));
	}

	public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
	{
	    const int BitsInLong = 64;
	    const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	    if (radix < 2 || radix > Digits.Length)
	        throw new ArgumentException("The radix must be >= 2 and <= " + Digits.Length);

	    if (decimalNumber == 0)
	        return "0";

	    int index = BitsInLong - 1;
	    long currentNumber = Math.Abs(decimalNumber);
	    char[] charArray = new char[BitsInLong];

	    while (currentNumber != 0)
	    {
	        int remainder = (int)(currentNumber % radix);
	        charArray[index--] = Digits[remainder];
	        currentNumber = currentNumber / radix;
	    }

	    string result = new String(charArray, index + 1, BitsInLong - index - 1);
	    if (decimalNumber < 0)
	    {
	        result = "-" + result;
	    }

	    return result;
	}
}