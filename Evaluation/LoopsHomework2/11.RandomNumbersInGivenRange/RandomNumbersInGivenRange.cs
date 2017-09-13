/*Problem 11. Random Numbers in Given Range 
 *Write a program that enters 3 integers n, min and max (min ≤ max) and prints n 
 *random numbers in the range [min...max].*/

using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random randNums = new Random();

        for (int i = 1; i <= n; i++)
        {
            Console.Write(randNums.Next(min,(max + 1)) + " ");
        }
        Console.WriteLine();
    }
}

