using System;
/*
 Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, 
or -1, if there’s no such element.
Use the method from the previous exercise.
 */
class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter number for the length of the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array [{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(Larger(arr));
    }
    static int Larger(int[] arr)
    {
        int position = -1;
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                position = i;
                break;
            }
        }
        return position;
    }
}
