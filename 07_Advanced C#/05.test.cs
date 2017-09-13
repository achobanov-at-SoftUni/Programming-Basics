using System;
using System.Linq;

class test
{
	static void Main()
	{
		int[] numbers = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();
		Console.WriteLine(LongestIncreasingSeq(numbers));
	}
	static public int LongestIncreasingSeq(int[] numbers) 
	{
	    int[] length = new int[numbers.Length];  // DP table for max length[i]
	    int maxlength = int.MinValue;
	    length[0] = 1;
	    for (int i = 1; i < numbers.Length; i++)
	    {
	        length[i] = 1;
	        for (int j = 0; j < i; j++)
	        {
	            if (numbers[j] <= numbers[i] && length[j] + 1 > length[i])
	            {
	                length[i] = length[j] + 1;
	                if (length[i] > maxlength)
	                {
	                    maxlength = length[i];
	                }
	            }
	        }
	    }
	    return maxlength;
	}
}