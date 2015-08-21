using System;
/*
 Problem 9. Sorting array

Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
 */
class SortingArray
{
    static void Main()
    {
        Console.Write("Enter number for the length of the array: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter a position to check [0..{0}]: ", n - 1);
        int index = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array [{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("The maximal element it the specified portion is: ");
        Console.WriteLine(MaxElement(index, arr));
        Console.WriteLine("Ascending order: ");
        AscendingOrder(arr);
        Console.WriteLine("Descending order: ");
        DescendingOrder(arr);
    }

    static int MaxElement ( int index, int[] arr)
    {
        int max = int.MinValue;
        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
    static int[] AscendingOrder (int[] arr)
    {
        Array.Sort(arr);
        Print(arr);
        return arr;
    }
    static int[] DescendingOrder(int[] arr)
    {
        Array.Reverse(arr);
        Print(arr);
        return arr;
    }
    static void Print (int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}