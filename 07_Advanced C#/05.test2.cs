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
	    //int[] length = Enumerable.Repeat(1, numbers.Length).ToArray();  // DP table for max length[i]
	    int[] length = new int[numbers.Length];
	    //int[] length = new int[] {0, 1, 1, 1, 1, 1, 1};
	    int maxlength = int.MinValue;
	    for (int i = 0; i < numbers.Length; i++)
	    {
	        length[i] = 1;
	        for (int j = 1; j < numbers.Length; j++)
	        {
	            if (numbers[j] >= numbers[i] && length[j] < length[i] + 1)
	            {
	                length[i] = length[i] + 1;
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