using System;
using System.Text;
/*
 Problem 23. Series of letters

Write a program that reads a string from the console and replaces all series of 
consecutive identical letters with a single one.
Example:

input	                output
aaaaabbbbbcdddeeeedssaa	abcdedsa
 */
class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter some text: ");
        string text = Console.ReadLine();

        StringBuilder newtext = new StringBuilder();// stringBuilder to store the new string

        char desiredLetter = text[0];// set the letter
        newtext.Append(text[0]);// add it to the stringBuilder

        for (int i = 0; i < text.Length; i++)
        {
            if (desiredLetter == text[i])
            {
                continue;
            }
            else
            {
                newtext.Append(text[i]);//if the letter is different, add it
                desiredLetter = text[i];
            }
        }
        newtext.ToString();//convert to string
        Console.WriteLine(newtext);//print
    }
}