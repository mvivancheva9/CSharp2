using System;
class FillTheMatrixA
{
    static void Main()
    {
        Console.Write("Enter a number for the length of the matrix: ");
        int n = int.Parse(Console.ReadLine());

        int[,] intMatrix = new int[n, n];

        intMatrix[0, 0] = 1;
        for (int i = 1; i < intMatrix.GetLength(0); i++)
        {
            intMatrix[0, i] = intMatrix[0, i - 1] + n;
        }

        for (int i = 1; i < intMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < intMatrix.GetLength(1); j++)
            {
                intMatrix[i, j] = intMatrix[i - 1, j] + 1;
            }
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

