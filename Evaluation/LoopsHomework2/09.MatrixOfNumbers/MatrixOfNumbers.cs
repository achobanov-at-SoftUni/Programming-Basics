/*Problem 9. Matrix of Numbers
 * Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a 
 * matrix like in the examples below. Use two nested loops.*/

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            for (int col = row + 1; col <= n + row; col++)
            {
                Console.Write("{0,2}",col);
            }
            Console.WriteLine();
        }
    }
}

