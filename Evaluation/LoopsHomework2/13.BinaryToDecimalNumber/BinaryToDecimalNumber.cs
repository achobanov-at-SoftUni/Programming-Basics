/*Problem 13. Binary to Decimal Number
 * Using loops write a program that converts a binary integer number to its decimal form. 
 * The input is entered as string. The output should be a variable of type long. 
 * Do not use the built-in .NET functionality. */

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string binaryInput = Console.ReadLine();
        long decimalForm = 0L;

        //for (int i = 0, bits = binaryInput.Length - 1; i < binaryInput.Length; i++, bits--)
        //{
        //    long temp = long.Parse(binaryInput[bits].ToString());
        //    decimalForm += temp * ((long)Math.Pow(2, i));
        //}
        //Console.WriteLine(decimalForm);

        for (int i = 0; i < binaryInput.Length; i++)
        {
            if (binaryInput[binaryInput.Length - i - 1] == '0')
            {
                continue;
            }
            decimalForm += (long)Math.Pow(2, i);
        }
        Console.WriteLine(decimalForm);
    }
}

