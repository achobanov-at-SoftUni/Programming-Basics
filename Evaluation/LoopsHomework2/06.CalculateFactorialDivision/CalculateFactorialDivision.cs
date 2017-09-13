/*Problem 6. Calculate N! / K!
 * Write a program that calculates n! / k! for given n and k (1 < k < n < 100). 
 * Use only one loop. Examples:*/

using System;
using System.Numerics;

class CalculateFactorialDivision
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger result = 1;

        for (int i = n; i > k; i--)
        {
            result *= i;
        }
        Console.WriteLine(result);
    }
}
