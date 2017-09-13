using System;
using System.Globalization;
using System.Threading;

class HalfSum
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int n = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            sum1 += a;
        }
        for (int i = 0; i < n; i++)
        {
            int b = int.Parse(Console.ReadLine());
            sum2 += b;
        }
        if (sum1 == sum2)
        {
            Console.WriteLine("Yes, sum={0}", sum1);
        }
        else if (sum1 > sum2)
        {
            Console.WriteLine("No, diff={0}", sum1 - sum2);
        }
        else if (sum2 > sum1)
        {
            Console.WriteLine("No, diff={0}", sum2 - sum1);
        }
    }
}

