using System;
/*
 Problem 14. Word dictionary

A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:

input	output
.NET	platform for applications from Microsoft
CLR	managed execution environment for .NET
namespace	hierarchical organization of classes
 */
class Dictionary
{
    static void Main()
    {
        Console.Write("Enter how many words you want to put in the dictionaty: ");
        int n = int.Parse(Console.ReadLine());

        string[] word = new string[n];// array that stores the lookup words
        string[] explanation = new string[n];// array that sorts the explanation
        for (int i = 0; i < n; i++)// fill the dictionary woth info
        {
            Console.Write("Enter word: ");
            word[i] = Console.ReadLine();
            Console.Write("Enter explanation: ");
            explanation[i] = Console.ReadLine();
        }
        Console.Write("Enter a word to check: ");// search for word
        string checkWord = Console.ReadLine();

        for (int i = 0; i < n; i++)
        {
            if (checkWord == word[i])// check for equality
            {
                Console.WriteLine("{0} means {1}.", word[i], explanation[i]);// print
                break;
            }
            else
            {
                Console.WriteLine("There is no such word in the dictionary");
                break;
            }
        }

    }
}