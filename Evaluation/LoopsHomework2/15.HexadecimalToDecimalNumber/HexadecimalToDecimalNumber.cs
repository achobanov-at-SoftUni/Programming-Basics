/*Problem 15. Hexadecimal to Decimal Number
 * Using loops write a program that converts a hexadecimal integer number to its decimal form. 
 * The input is entered as string. The output should be a variable of type long. 
 * Do not use the built-in .NET functionality. */

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string hexInput = Console.ReadLine();
        long counter = 0L;
        long dec = 0L;
        long digit = 0L;
        for (int i = hexInput.Length - 1; i >= 0; i--)
        {
            if (hexInput[i] > '0' + 9)
            {
                digit = hexInput[i] - 55;
            }
            else
            {
                digit = hexInput[i] - 48;
            }
            dec += digit * (long)Math.Pow(16, counter);
            counter++;
        }
        Console.WriteLine(dec);

    }
}

