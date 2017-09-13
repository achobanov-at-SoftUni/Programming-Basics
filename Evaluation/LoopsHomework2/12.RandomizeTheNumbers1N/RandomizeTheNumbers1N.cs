/*Problem 12.* Randomize the Numbers 1…N 
 * Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. */

using System;
using System.Linq;

class RandomizeTheNumbers1N
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] range = new int[n];
        Random rand = new Random();
        range = Enumerable.Range(1, n).OrderBy(r => rand.Next()).ToArray();
        foreach (var num in range)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

    }
}

