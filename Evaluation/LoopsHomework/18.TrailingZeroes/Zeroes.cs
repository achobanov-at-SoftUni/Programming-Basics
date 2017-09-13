using System;
    class Zeroes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            int trailingZero = 0;
            while (Math.Pow(5, k) < n)
            {
                k++;
                trailingZero += n / (int)(Math.Pow(5, k));
            }
            Console.WriteLine(trailingZero);
        }
    }
        
    

