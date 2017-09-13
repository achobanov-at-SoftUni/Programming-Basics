using System;
 
class BitsAtCrossroads
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long[] matrix = new long[n];
        string inputLine;
        int countCross = 0;
        while (!((inputLine = Console.ReadLine()) == "end"))
        {
            int[] input = Array.ConvertAll(inputLine.Split(' '), s => int.Parse(s));
            int rowX = input[0];
            int colX = input[1];
            matrix[rowX] |= 1L << colX;
            countCross++;
            countCross += Diagonals(matrix, rowX, colX, 1, 1);
            countCross += Diagonals(matrix,  rowX, colX, -1, -1);
            countCross += Diagonals(matrix,  rowX, colX, -1, 1);
            countCross += Diagonals(matrix,  rowX, colX, 1, -1);
        }
        foreach (var num in matrix)
        {
            //Console.WriteLine(Convert.ToString(num, 2).PadLeft(n, '0'));
            Console.WriteLine(num);
        }
        Console.WriteLine(countCross);
    }
 
    private static int Diagonals(long[] matrix, int row, int col, int rowChange, int colChange)
    {
        int countX = 0;
        row += rowChange;
        col += colChange;
        while (row >= 0 && row < matrix.Length && col >= 0 && col < matrix.Length)
        {
            if ((matrix[row] >> col & 1L) == 1)
            {
                countX++;
            }
            else
            {
                matrix[row] |= 1L << col;
            }
            row += rowChange;
            col += colChange;
        }
        return countX;
    }
}