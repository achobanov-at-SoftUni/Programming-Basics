/*Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
 * Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
 * Use only one loop. Print the result with 5 digits after the decimal point.*/

using System;

class CalculateTheSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        double result = 1;
        double factorial = 1;
        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            result *= x;
            sum += (factorial / result);
        }
        Console.WriteLine("{0:F5}", 1 + sum);
    }
}

