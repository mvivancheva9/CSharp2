using System;
using System.Numerics;
/*
 Problem 14. Integer calculations

Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
 */
class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("Enter sequence of elements: ");
        string[] arrayElements =  Console.ReadLine().Split(' ');
        int[] sequenceOfElements = new int[arrayElements.Length];
        for (int i = 0; i < arrayElements.Length; i++)
        {
            sequenceOfElements[i] = int.Parse(arrayElements[i]);
        }

        Console.WriteLine("The minimum element is: {0}", Minimum(sequenceOfElements));
        Console.WriteLine("The maximum element is: {0}", Maximum(sequenceOfElements));
        Console.WriteLine("The average is: {0}", Average(sequenceOfElements));
        Console.WriteLine("The sum is: {0}", Sum(sequenceOfElements));
        Console.WriteLine("The product is: {0}", Product(sequenceOfElements));
    }
    static int Minimum(int[] sequenceOfElements)
    {
        int min = int.MaxValue;
        for (int i = 0; i < sequenceOfElements.Length; i++)
        {
            if (sequenceOfElements[i] < min)
            {
                min = sequenceOfElements[i];
            }
        }
        return min;
    }
    static int Maximum(int[] sequenceOfElements)
    {
        int max = int.MinValue;
        for (int i = 0; i < sequenceOfElements.Length; i++)
        {
            if (sequenceOfElements[i] > max)
            {
                max = sequenceOfElements[i];
            }
        }
        return max;
    }
    static decimal Sum(int[] sequenceOfElements)
    {
        decimal sum = 0;
        for (int i = 0; i < sequenceOfElements.Length; i++)
        {
            sum += sequenceOfElements[i];
        }
        return sum;
    }
    static decimal Average(int[] sequenceOfElements)
    {
        decimal average = Sum(sequenceOfElements) / sequenceOfElements.Length;
        
        return average;
    }
    static BigInteger Product(int[] sequenceOfElements)
    {
        BigInteger product = 1;
        for (int i = 0; i < sequenceOfElements.Length; i++)
        {
            product *= sequenceOfElements[i];
        }
        return product;
    }

}