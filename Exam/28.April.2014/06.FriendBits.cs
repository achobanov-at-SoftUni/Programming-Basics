using System;

class FriendBits
{
	static void Main()
	{
		uint input = uint.Parse(Console.ReadLine());
		uint friends = 0;
		uint lones = 0;
		string binSequence = Convert.ToString(input, 2);
		for(int bit = binSequence.Length - 1; bit >= 0; bit--)
		{
			uint currentBit = (input >> bit) & 1;
			
			bool hasLeft = bit < binSequence.Length - 1;
			uint leftBit = (input >> bit + 1) & 1;
			bool sameAsLeft = hasLeft && currentBit == leftBit;
			
			bool hasRight = bit != 0;
			uint rightBit = (input >> bit - 1) & 1;
			bool sameAsRight = hasRight && currentBit == rightBit;
			
			bool areFriends = sameAsLeft || sameAsRight;
			if(areFriends)
			{
				friends = (friends << 1) | currentBit;
			}
			else
			{
				lones = (lones << 1) | currentBit;
			}
		}
		Console.WriteLine(friends + "\n" + lones);
	}
}