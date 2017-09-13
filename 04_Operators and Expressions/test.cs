using System;

class BitsUp
{
    static void Main()
    {
        int 
        	n = int.Parse(Console.ReadLine()),
       		step = int.Parse(Console.ReadLine()),
       		counter = 0
       	;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {
                if ((counter % step == 1) || (step == 1 && counter > 0))
                {
                    number = number | (1 << bit);
                }
                index++;
            }
            Console.WriteLine(number);
        }
    }
}
