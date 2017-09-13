/*Problem 18.* Trailing Zeroes in N!
 * Write a program that calculates with how many zeroes the factorial of a given number n has at its end. 
 * Your program should work well for very big numbers, e.g. n=100000. */

using System;
using System.Numerics;

class TrailingZeroesInN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        //BigInteger factorial = 1;
        //for (int i = 1; i <= n; i++)
        //{
        //    factorial *= i;
        //}
        //Console.WriteLine(factorial);

        for (int zeroes = 1; Math.Pow(5, zeroes) <= n; zeroes++)
        {
            count += n / (int)Math.Pow(5, zeroes);
        }
        Console.WriteLine(count);
    }
}

