using System;
using System.Linq;

class Problem5
{
	static void Main()
	{
		string input = Console.ReadLine();
		long[] numbers = input.Split(' ').Select(a => Convert.ToInt64(a)).ToArray();
		for(int i = 0, n = numbers.Length; i < n; i += 2)
		{
			for(int bit = 62; bit >= 0; bit--)
			{
				if(bit % 2 == 0)
				{
					long holder1 = (numbers[i] >> bit) & 1;
					long holder2 = (numbers[i + 1] >> bit) & 1;
					numbers[i] ^= (-holder2 ^ numbers[i]) & ((long)1 << bit);
					// Console.WriteLine(Convert.ToString(numbers[i], 2).PadLeft(63, '0'));
					numbers[i + 1] ^= (-holder1 ^ numbers[i + 1]) & ((long)1 << bit);
					// Console.WriteLine(Convert.ToString(numbers[i + 1], 2).PadLeft(63, '0'));
				}
			}
			numbers[i] = ~numbers[i];
			numbers[i] &= ~((long)1 << 63);
			numbers[i + 1] = ~numbers[i + 1];
			numbers[i + 1] &= ~((long)1 << 63);
		}
		foreach(long num in numbers)
		{
			Console.WriteLine("{0} {1}", (decimal)num, Convert.ToString(num, 2));
		}
	}
}