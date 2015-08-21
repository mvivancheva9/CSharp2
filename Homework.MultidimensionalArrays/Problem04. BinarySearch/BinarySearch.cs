using System;
using System.Collections;
/*
 Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K, 
sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
 */
class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter a number for the length of the array: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter a number for the comapring value: ");
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Array [{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);

        int index = Array.BinarySearch(arr, k);
        if (index < 0)
        {
            index = ~index;
            Console.WriteLine("{0} ", arr[index - 1]);

        }
        else
        {
            Console.WriteLine(arr[index]);
        }

    }
}