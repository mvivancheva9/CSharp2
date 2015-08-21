using System;
class FillTheMatrixB
{
    static void Main()
    {
        Console.Write("Enter a number for the length of the matrix: ");
        int n = int.Parse(Console.ReadLine());

        int[,] intMatrix = new int[n, n];

        intMatrix[0, 0] = 1;
        for (int i = 1; i < intMatrix.GetLength(0); i++)
        {
            if (i % 2 == 1)
            {
                intMatrix[0, i] = intMatrix[0, i - 1] + 2 * n - 1;
            }
            else if (i % 2 == 0)
            {
                intMatrix[0, i] = intMatrix[0, i - 1] + 1;
            }
        }

        for (int i = 1; i < intMatrix.GetLength(0); i++)
        {

            for (int j = 0; j < intMatrix.GetLength(1); j++)
            {
                if (j % 2 == 0)
                {
                    intMatrix[i, j] = intMatrix[i - 1, j] + 1;
                }
                else if (j % 2 == 1)
                {
                    intMatrix[i, j] = intMatrix[i - 1, j] - 1;
                }

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
