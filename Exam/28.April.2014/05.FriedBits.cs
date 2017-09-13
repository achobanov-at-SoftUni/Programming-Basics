using System;

class FriendBits
{
	static void Main()
	{
		uint 
			input = uint.Parse(Console.ReadLine()),
			friends = 0,
			lones = 0
		;
		string binSequence = Convert.ToString(input, 2);
		int incrementFriends = 1;
		for(int bit = binSequence.Length - 2; bit >= 0; bit--)
		{
			int previousBit = (int)(input >> bit + 1) & 1;
			int currentBit = (int)(input >> bit) & 1;
			if(currentBit == previousBit)
			{
				incrementFriends++;
				if(bit == 0 && incrementFriends != 1)
				{
					for(int i = 0; i < incrementFriends; i++)
					{
						friends <<= 1;
						friends |= (uint)(previousBit);
					}
				}
			}
			else 
			{
				if(incrementFriends != 1)
				{
					for(int i = 0; i < incrementFriends; i++)
					{
						friends <<= 1;
						friends |= (uint)(previousBit);
					}
				}
				if(incrementFriends == 1 || bit == 0)
				{
					lones <<= 1;
					if(bit == 0)
					{
						if(incrementFriends == 1)
						{
							lones |= (uint)previousBit;
							lones <<= 1;
						}
						lones |= (uint)currentBit;
					}
					else
					{
						lones |= (uint)previousBit;
					}
				}
				incrementFriends = 1;
			}
		}
		Console.WriteLine(friends + "\n" + lones);
	}	
}