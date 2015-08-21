using System;
class FillTheMatrixC
{
    static void Main()
    {
        Console.Write("Enter a number for the length of the matrix: ");
        int n = int.Parse(Console.ReadLine());

        int[,] intMatrix = new int[n, n];

        // fill the matrix
        intMatrix[n - 1, 0] = 1;
        int counter = 1;
        for (int row = n - 2; row >= 0; row--)
        {
            intMatrix[row, 0] = intMatrix[row + 1, 0] + counter;
            int newRow = row;
            for (int diagonal = 1; diagonal <= counter; diagonal++)
            {
                intMatrix[newRow + 1, diagonal] = intMatrix[newRow, diagonal - 1] + 1;
                newRow++;
            }
            counter++;
        }

        intMatrix[0, n - 1] = n * n;
        int diagonalLength = 2;
        int posX = 1;
        int posY = n - 1;
        int prevX = 0;
        int prevY = n - 1;

        for (int i = 1; i < counter - 1; i++)
        {
            for (int j = 1; j <= diagonalLength; j++)
            {
                intMatrix[posX, posY] = intMatrix[prevX, prevY] - 1;
                prevX = posX;
                prevY = posY;
                posX--;
                posY--;
            }
            diagonalLength++;
            posX = i + 1;
            posY = n - 1;
        }

        for (int i = 0; i < intMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < intMatrix.GetLength(1); j++)
            {
                Console.Write("{0,2} ", intMatrix[i, j]);
            }
            Console.WriteLine();
        }


    }
}