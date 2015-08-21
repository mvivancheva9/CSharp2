using System;
/*
 Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
 */
class AppearanceCount
{
    static void Main()
    {
        Console.Write("Enter number for the length of the array: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter a number to check: ");
        int checkNumber = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array [{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Number {0} is seen ", checkNumber);
        Console.WriteLine(Count(checkNumber, arr) + " times");
    }
    static int Count (int checkNumber, int[] arr)
    {
        int counter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == checkNumber)
            {
                counter++;
            }
        }
        return counter;
    }
    
}
