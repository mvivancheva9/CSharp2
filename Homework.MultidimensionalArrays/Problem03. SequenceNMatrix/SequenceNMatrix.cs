using System;
/*
 Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements 
located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
 */
class SequenceNMatrix
{
    static void Main()
    {
        Console.Write("Enter a number for the rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter a number for the columns: ");
        int columns = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, columns];
        string input;
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Console.Write("matrix[{0},{1}] = ", row, column);
                input = Console.ReadLine();
                matrix[row, column] = input;
            }
        }
        int max = 0;
        int CurrentCounter = 0;
        string maxString = "";

        // Find sequence
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                // For current element, goto end horizontally, count elements
                CurrentCounter = 0;
                for (int k = column; k < columns - 1; k++)
                {
                    if (matrix[row, k] == matrix[row, k + 1])
                    {
                        CurrentCounter++;
                    }

                    if (CurrentCounter > max)
                    {
                        max = CurrentCounter;
                        maxString = matrix[row, k];
                    }
                    
                }

                // For current element, goto end vertically, count elements
                CurrentCounter = 0;
                for (int k = row; k < row - 1; k++)
                {
                    if (matrix[k, column] == matrix[k + 1, column])
                    {
                        CurrentCounter++;
                    }

                    if (CurrentCounter > max)
                    {
                        max = CurrentCounter;
                        maxString = matrix[k, column];
                    }
                    
                }

                // For current element, goto end diagonally, count elements
                CurrentCounter = 0;
                for (int k = row, l = column; (k < rows - 1) && (l < columns - 1); k++, l++)
                {
                    if (matrix[k, l] == matrix[k + 1, l + 1])
                    {
                        CurrentCounter++;
                    }

                    if (CurrentCounter > max)
                    {
                        max = CurrentCounter;
                        maxString = matrix[k, l];
                    }
                    
                }
            }
        }

        for (int i = 0; i < max + 1; i++) Console.Write("{0} ", maxString);

        Console.WriteLine();
    }
}