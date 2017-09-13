using System;

class OddEvenElements
{
    static void Main()
    {
        string[] inputNumbers = Console.ReadLine().Split(new char[] { ' ' });

        if (inputNumbers[0] == string.Empty)
        {
            // Known issue: split on empty string returns 1 token ""
            inputNumbers = new string[0];
        }

        if (inputNumbers.Length <= 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            return;
        }
        double oddSum = 0;
        double oddMin = double.MaxValue;
        double oddMax = double.MinValue;
        double evenSum = 0;
        double evenMin = double.MaxValue;
        double evenMax = double.MinValue;

        for (int i = 1; i <= inputNumbers.Length; i++)
        {
            double num = double.Parse(inputNumbers[i - 1]);
            if (i % 2 != 0)
            {
                oddSum += num;
                oddMin = Math.Min(num, oddMin);
                oddMax = Math.Max(num, oddMax);
            }
            else if (i % 2 == 0)
            {
                evenSum += num;
                evenMin = Math.Min(num, evenMin);
                evenMax = Math.Max(num, evenMax);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        if (inputNumbers.Length == 1)
        {
            Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum=No, EvenMin=No, EvenMax=No", oddSum, oddMin, oddMax);
        }
        else
        {
            Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum={3:0.##}, EvenMin={4:0.##}, EvenMax={5:0.##}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
        }
    }
}

