using System;
    class Calculate
    {
        static void Main()
        {
        Console.WriteLine("Please enter X");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter N");
        int n = int.Parse(Console.ReadLine());
        int Factorial = 1;
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            Factorial *= i;
            sum += (Factorial / Math.Pow(x, i));
        }
        Console.WriteLine("{0:F5}", sum);

    }
    }
