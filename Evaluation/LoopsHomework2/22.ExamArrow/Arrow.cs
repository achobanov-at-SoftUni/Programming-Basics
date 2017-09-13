using System;

class Arrow
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int topToMiddle = width - 2;
        char arrow = '#';
        char backGrownd = '.';
        int innerDots = (width * 2) - 5;
        int outterDots = 1;

        Console.WriteLine("{0}{1}{0}",new string(backGrownd, width / 2), new string(arrow, width));

        for (int i = 0; i < topToMiddle; i++)
        {
            Console.WriteLine("{0}{2}{1}{2}{0}", new string(backGrownd, width / 2), new string(backGrownd, width - 2), arrow);
        }

        Console.WriteLine("{0}{1}{0}", new string(arrow, (width / 2) + 1), new string(backGrownd, width - 2));

        for (int i = 0; i < topToMiddle; i++)
        {
            Console.WriteLine("{0}{2}{1}{2}{0}", new string(backGrownd, outterDots), new string(backGrownd, innerDots), arrow);
            outterDots++;
            innerDots -= 2;
        }
        Console.WriteLine("{0}{1}{0}", new string(backGrownd, width - 1), arrow);
    }
}

