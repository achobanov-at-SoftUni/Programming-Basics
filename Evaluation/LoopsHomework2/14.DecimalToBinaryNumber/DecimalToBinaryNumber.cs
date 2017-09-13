/*Problem 14. Decimal to Binary Number
 * Using loops write a program that converts an integer number to its binary representation. 
 * The input is entered as long. The output should be a variable of type string.
 * Do not use the built-in .NET functionality. */

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        //string decimalInput = Console.ReadLine();
        //int fromBase = 10;
        //int toBase = 2;

        //String result = Convert.ToString(Convert.ToInt32(decimalInput, fromBase), toBase);
        //Console.WriteLine(result);

        //int inputNumer = int.Parse(Console.ReadLine());
        //string binary = Convert.ToString(inputNumer, 2).PadLeft(32, '0');
        //Console.WriteLine("Your number {0} looks like this in binary form (32 bits number)\r\n{1}", inputNumer, binary);

        //int n = int.Parse(Console.ReadLine());

        //int[] binNumber = new int[28];
        //int digit;

        //for (int i = 0; i < 28; i++)
        //{
        //    if ((digit = n & 1 << i) != 0)
        //    {
        //        binNumber[i] = 1;
        //    }
        //}

        //for (int i = binNumber.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(binNumber[i]);
        //}
        //Console.WriteLine();

        long inputDecimal = long.Parse(Console.ReadLine());
        string binaryOutput = null;

        if (inputDecimal == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            while (inputDecimal >= 1)
            {
                binaryOutput = (inputDecimal % 2) + binaryOutput;
                inputDecimal = inputDecimal / 2;
            }
            Console.WriteLine(binaryOutput);
        }
    }
}

