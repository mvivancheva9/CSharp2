using System;
/*
 Problem 6.* Matrix class

Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, 
subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().
 */
class MatrixClass
{
    static void Main()
    {
        Console.Write("Enter number for the dimensions of the two matrices: ");
        int n = int.Parse(Console.ReadLine());

        Matrix firstMatrix = new Matrix(n, n);
        Matrix secondMatrix = new Matrix(n , n);

        int inputFirstMatrix;
        int inputSecondMatrix;
        for (int row = 0; row < firstMatrix.Rows; row++)
        {
            for (int column = 0; column < firstMatrix.Columns; column++)
            {
                Console.Write("matrix1[{0},{1}] = ", row, column);
                inputFirstMatrix = int.Parse(Console.ReadLine());
                firstMatrix[row, column] = inputFirstMatrix;
            }
        }
        
        for (int row = 0; row < secondMatrix.Rows; row++)
        {
            for (int column = 0; column < secondMatrix.Columns; column++)
            {
                Console.Write("matrix2[{0},{1}] = ", row, column);
                inputSecondMatrix = int.Parse(Console.ReadLine());
                secondMatrix[row, column] = inputSecondMatrix;
            }
        }
       
        Matrix sum = firstMatrix + secondMatrix;
        Console.WriteLine("Addition Matrix: ");
        Console.WriteLine(sum.ToString());

        Matrix subtract = firstMatrix - secondMatrix;
        Console.WriteLine("Subtraction Matrix: ");
        Console.WriteLine(subtract.ToString());

        Matrix multiply = firstMatrix * secondMatrix;
        Console.WriteLine("Multiplication Matrix: ");
        Console.WriteLine(multiply.ToString());
    }
}