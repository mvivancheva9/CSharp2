using System;
using System.IO;
/*
 Problem 5. Maximal area sum

Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
Example:

input	output
4 
2 3 3 4  17
0 2 3 4 
3 7 1 2 
4 3 3 2
 */
class MaximalAreaSum
{
    static void Main()
    {
        using (StreamReader stream = new StreamReader("Matrix.txt"))
        {
            string line = stream.ReadLine();

            int n = int.Parse(line);
            int[,] matrix = new int[n, n];

            int bestStum = 0;
            for (int i = 0; i < n; i++)
            {
                line = stream.ReadLine();// get the line
                string[] currentLine = line.Split(' ');// remove empty spaces
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(currentLine[j]);// fill the matrix
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    int sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                    if (sum > bestStum)
                    {
                        bestStum = sum;// search for best sum
                    }
                }
            }
            Console.WriteLine(bestStum);
        }

    }
}