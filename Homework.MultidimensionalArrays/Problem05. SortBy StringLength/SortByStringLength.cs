using System;
/*
 Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array by the length of its elements 
(the number of characters composing them).
 */
class SortByStringLength
{

    static void Main()
    {
        Console.Write("Enter words, separated with SPACE: ");
        string[] arr = Console.ReadLine().Split(' ');

        SortByString(arr);

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }



    }
    static void SortByString(string[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                
                if (arr[j].Length < arr[i].Length)
                {
                    string currentWord = arr[i];
                    arr[i] = arr[j];
                    arr[j] = currentWord;
                } 
                else if (arr[j].Length == arr[i].Length)
                {
                    char[] array1 = arr[i].ToCharArray();
                    char[] array2 = arr[j].ToCharArray();
                    for (int index = 0; index < arr[i].Length; index++)
                    {
                        char symbolArray1 = array1[index];
                        char symbolArray2 = array2[index];

                        if (symbolArray1 == symbolArray2 || symbolArray1 < symbolArray2)
                        {
                            continue;
                        }
                        else
                        {
                            string currentWord = arr[i];
                            arr[i] = arr[j];
                            arr[j] = currentWord;
                        }
                        break;
                    }
                    


                }
            }
        }
    }
}