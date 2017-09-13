/*Problem 4. Print a Deck of 52 Cards
 * Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
 * The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start 
 * from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
 * Use 2 nested for-loops and a switch-case statement.*/

using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        char spade = '\u2660';
        char heart = '\u2665';
        char club = '\u2663';
        char diamond = '\u2666';

        for (int cards = 2; cards < 15; cards++)
        {
            for (int suits = 0; suits < 4; suits++)
            {
                switch (cards)
                {
                    case 2: Console.Write("{0,2}", "2");
                        break;
                    case 3: Console.Write("{0,2}", "3");
                        break;
                    case 4: Console.Write("{0,2}", "4");
                        break;
                    case 5: Console.Write("{0,2}", "5");
                        break;
                    case 6: Console.Write("{0,2}", "6");
                        break;
                    case 7: Console.Write("{0,2}", "7");
                        break;
                    case 8: Console.Write("{0,2}", "8");
                        break;
                    case 9: Console.Write("{0,2}", "9");
                        break;
                    case 10: Console.Write("{0,2}", "10");
                        break;
                    case 11: Console.Write("{0,2}", "J");
                        break;
                    case 12: Console.Write("{0,2}", "Q");
                        break;
                    case 13: Console.Write("{0,2}", "K");
                        break;
                    case 14: Console.Write("{0,2}", "A");
                        break;
                    default: Console.WriteLine("Invalid card");
                        break;
                }
                switch (suits)
                {
                    case 0: Console.Write("{0} ", club); break;
                    case 1: Console.Write("{0} ", diamond); break;
                    case 2: Console.Write("{0} ", heart); break;
                    case 3: Console.Write("{0} ", spade); break;
                    default: Console.WriteLine("Invalid suit");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}

