using System;

class SunGlasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string Stars = new string('*', n * 2);
        string innerLines = new string('/', n * 2 - 2);
        string innerStars = new string('*', 1);
        string Empty = new string(' ', n);
        string pipe = new string('|', n);


        Console.WriteLine(Stars + Empty + Stars);
        if(n == 3)
        {
        	n = n + 1;
        }
        for (int i = 0; i < n - 3; i++)
        {

            if (i == n / 2 - 1)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", innerStars, innerLines, pipe);
            }

            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", innerStars, innerLines, Empty);

        }
        Console.WriteLine(Stars + Empty + Stars);
    }
}
