﻿using System;
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 14; i++)
            {
                for (int j = 5; j < 7; j--)
                {
                    if (i < 11)
                    {
                        Console.Write("{0}{1} ", i, (char)j);
                    }
                    switch (i)
                    {
                        case 11: Console.Write("J{0} ", (char)j);
                            break;
                        case 12: Console.Write("Q{0} ", (char)j);
                            break;
                        case 13: Console.Write("K{0} ", (char)j);
                            break;
                        case 14: Console.Write("A{0} ", (char)j);
                            break;
                    }
                    if (j == 3)
                    {
                        j = 7;
                    }
                    if (j == 6)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
        
    

