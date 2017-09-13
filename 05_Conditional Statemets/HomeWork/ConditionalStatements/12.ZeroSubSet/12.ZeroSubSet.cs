using System;

class ZeroSubset
{
	static void Main()
	{
		int[] numbers = new int[5];
		int 
			sum = 0,
			counter = 0
		;
		for(int i = 0; i < 5; i++)
		{
			numbers[i] = int.Parse(Console.ReadLine());
		}
		// Checks if sum of all ints is equal to zero.
		if(numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
		{
			counter++;
			Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
		}
		// Series of nested loops to check each individial combination (with repetition)
		for(int i1 = 0; i1 < 4; i1++)
		{
			sum = numbers[i1];
			for(int i2 = i1 + 1; i2 < 5; i2++)
			{
				sum = numbers[i1] + numbers[i2];
				if(sum == 0)
				{
					counter++;
					Console.WriteLine("{0} + {1} = 0", numbers[i1], numbers[i2]);
				}
				for(int i3 = i2 + 1; i3 < 5; i3++)
				{
					sum = numbers[i1] + numbers[i2] + numbers[i3];
					if(sum == 0)
					{
						counter++;
						Console.WriteLine("{0} + {1} + {2} = 0", numbers[i1], numbers[i2], numbers[i3]);
					}
					for(int i4 = i3 + 1; i4 < 5; i4++)
					{
						sum = numbers[i1] + numbers[i2] + numbers[i3] + numbers[i4];
						if(sum == 0)
						{
							counter++;
							Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[i1], numbers[i2], numbers[i3], numbers[i4]);
						}
					}
				}
			}
		}
		if(counter == 0)
		{
			Console.WriteLine("No zero subset."); 
		}
	}
}