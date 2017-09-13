/*Problem 8. Catalan Numbers
 * In combinatorics, the Catalan numbers are calculated by the following formula:
 * Write a program to calculate the nth Catalan number by given n (1 < n < 100). 
*/

using System;
using System.Numerics;

class CatalanNumbers
{
    static BigInteger Factorial(int x)
    {
        BigInteger result;
        if (x == 0) return 1;
        result = x * Factorial(x - 1);
        return result;
    }
    static void Main()
    {
        Console.Write("Enter number n (1 < n < 100) : ");
        int n = int.Parse(Console.ReadLine());

        BigInteger CatalanNumber = (Factorial(2 * n)) / (Factorial(n + 1) * Factorial(n));

        Console.Write("The n-th Catalan number is : ");
        Console.WriteLine(CatalanNumber);
    }
}

