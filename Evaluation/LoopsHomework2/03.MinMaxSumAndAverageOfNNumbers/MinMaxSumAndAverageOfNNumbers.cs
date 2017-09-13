/*Problem 3. Min, Max, Sum and Average of N Numbers
 * Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
 * the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
 * The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. */

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        double sum = 0D;
        double avg = 0D;

        for (int i = 0; i < input; i++)
        {
            int num = int.Parse(Console.ReadLine());

            min = Math.Min(min, num);
            max = Math.Max(max, num);
            sum += num;
            avg = sum / input;
        }
        Console.WriteLine("min = {0}\r\n" + "max = {1}\r\n" + "sum = {2}\r\n" + "avg = {3:F2}", min,max,sum,avg);
    }
}

