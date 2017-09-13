using System;

class SpiralMatrix
{
	static void Main()
	{
		int size = int.Parse(Console.ReadLine());
		//string word = Console.ReadLine();
		int[,] matrix = new int[size, size];
		int rowMin = 0;
		int rowMax = size - 1;
		int colMin = 0;
		int colMax = size - 1;
		int count = 0;
		while(true)
		{
			for(int right = 0; right < colMax + 1; right++)
			{
				matrix[rowMin, colMin + right] = 1;
			}
			rowMin++;
			count++;
			if(count == size * 2 - 1)
			{
				break;
			}
			for(int down = 0; down < rowMax; down++)
			{
				matrix[rowMin + down, colMax] = 2;
			}
			colMax--;
			count++;
			for(int left = 0; left < colMax + 1; left++)
			{
				matrix[rowMax, colMax - left] = 3;
			}
			rowMax--;
			count++;
			for(int up = 0; up < rowMax; up++)
			{
				matrix[rowMax - up, colMin] = 4;
			}
			colMin++;
			count++;
		}
		for(int row = 0; row < size; row++)
		{
			for(int col = 0; col < size; col++)
			{
				Console.Write(matrix[row, col] + " ");
			}
			Console.WriteLine();
		}	
	}
}