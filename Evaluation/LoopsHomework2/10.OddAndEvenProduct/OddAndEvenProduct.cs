/*Problem 10. Odd and Even Product
 * You are given n integers (given in a single line, separated by a space). Write a program that checks whether 
 * the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, 
 * so the first element is odd, the second is even, etc.*/

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] str = input.Split(new char[] {' '} , StringSplitOptions.RemoveEmptyEntries);
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 1; i <= str.Length; i++)
        {
            int numbers = int.Parse(str[i - 1]);
            if (i % 2 == 0)
            {
                evenProduct *= numbers;
            }
            else
            {
                oddProduct *= numbers;
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes\r\nproduct = {0}", oddProduct);
        }
        else if(oddProduct != evenProduct)
        {
            Console.WriteLine("no\r\nodd_product = {0}\r\neven_product = {1}", oddProduct, evenProduct);
        }
    }
}
