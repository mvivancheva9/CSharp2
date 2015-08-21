using System;
class MaximalSum
{
    //Problem 2. Maximal sum

    //Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
    //that has maximal sum of its elements.
    static void Main()
    {
        Console.Write("Enter a number for the rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter a number for the columns: ");
        int columns = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, columns];
        String inputNumber;
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Console.Write("matrix[{0},{1}] = ", row, column);
                inputNumber = Console.ReadLine();
                matrix[row, column] = int.Parse(inputNumber);
            }
        }
        int width = 3;
        int height = 3;
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - height + 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - width + 1; col++)
            {
                int sum = 0;

                for (int numbersRow = row; numbersRow < row + height; numbersRow++)
                {
                    for (int numbersCol = col; numbersCol < col + width; numbersCol++)
                    {
                        sum += matrix[numbersRow, numbersCol];
                    }
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        for (int numbersRow = bestRow; numbersRow < bestRow + height; numbersRow++)
        {
            for (int numbersCol = bestCol; numbersCol < bestCol + width; numbersCol++)
            {
                Console.Write("{0} ", matrix[numbersRow, numbersCol]);
            }
            Console.WriteLine();
        }
    }
}