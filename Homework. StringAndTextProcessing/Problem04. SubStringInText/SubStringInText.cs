using System;
/*
 Problem 4. Sub-string in text

Write a program that finds how many times a sub-string is contained in a given text 
(perform case insensitive search).
Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. 
inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
 */
class SubStringInText
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string textInput = Console.ReadLine();

        Console.Write("Enter a lookup word: ");
        string lookupWord = Console.ReadLine();

        Console.WriteLine("Seen {0} time(s).", SubstringCheck(textInput, lookupWord));
    }
    static int SubstringCheck( string textInput, string lookupWord)
    {
        int substringCounter = 0;// set a counter

        for (int i = 0; i < textInput.Length - lookupWord.Length; i++)// loop through the elements
        {
            string substring = textInput.Substring(i, lookupWord.Length).ToLower();// get a substring from the text

            if(substring == lookupWord)// check for equality
            {
                substringCounter++;
            }
        }
        return substringCounter;
    }
}