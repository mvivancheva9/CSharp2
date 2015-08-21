using System;
/*
 Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger 
than its two neighbours (when such exist).
 */
class LargerThanNeighbours
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
        Console.WriteLine(Bigger(index, arr));
    }
    static bool Bigger ( int index, int[] arr)
    {
        bool isBigger = false;
        
        if (index == 0)
        {
            if (arr[index] > arr[index + 1])
            {
                isBigger = true;
            }
        }
        else if (index == arr.Length)
        {
            if (arr[index] > arr[index - 1])
            {
                isBigger = true;
            }
        }
        else if (arr[index] > arr[index - 1] && arr[index] > arr[index - 1])
        {
            isBigger = true;
        }
        return isBigger;
    }
}