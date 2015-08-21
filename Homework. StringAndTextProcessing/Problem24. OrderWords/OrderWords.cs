using System;
/*
 Problem 24. Order words

Write a program that reads a list of words, separated by spaces and prints the
list in an alphabetical order.
 */

class OrderWords
{
    static void Main()
    {
        Console.Write("Enter some words, separated by SPACE: ");
        string[] words = Console.ReadLine().Split(' ');

        Array.Sort(words);// sort method
        foreach (var word in words)
        {
            Console.Write("{0} ", word);// print
        }
        Console.WriteLine();
    }
}