/*Problem 17.* Calculate GCD
 * Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. 
 * Use the Euclidean algorithm (find it in Internet). */

using System;

class CalculateGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                if (b < 0)
                {
                    b = Math.Abs(b);
                }
                a %= b;
            }
            else
            {
                if (a < 0)
                {
                    a = Math.Abs(a);
                }
                b %= a;
            }
        }
        if (a == 0)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(a);
        }
    }
}

