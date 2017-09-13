/*Problem 16. Decimal to Hexadecimal Number
 * Using loops write a program that converts an integer number to its hexadecimal representation.
 * The input is entered as long. The output should be a variable of type string.
 * Do not use the built-in .NET functionality.*/

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long decimalInput = long.Parse(Console.ReadLine());
        string hex = null;
        long remainder = long.MaxValue;

        if (decimalInput == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            while (decimalInput > 0)
            {
                remainder = decimalInput % 16;
                decimalInput = decimalInput / 16;
                if (remainder > 9)
                {
                    hex += (char)(65 + remainder - 10);
                }
                else
                {
                    hex += (char)('0' + remainder);
                }
            }
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                Console.Write(hex[i]);
            }
            Console.WriteLine();
        }
    }
}

