using System;
/*
 Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
 */
class SumIntegers
{
    static void Main()
    {
        Console.Write("Enter numbers separated by SPACE: ");
        string[] stringNums = Console.ReadLine().Split(' ');// write the numbers

        int[] sequnce = new int[stringNums.Length];// set an array with the legth of the entered numbers

        for (int i = 0; i < stringNums.Length; i++)
        {
            sequnce[i] = int.Parse(stringNums[i]);// fill the array
        }
        Console.WriteLine("The sum of the numbers is: {0}", Sum(sequnce));// print & call the sum method
    }
    static long Sum (int[] sequence)
    {
        long sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum;
    }
}