using System;
/*
 Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 
4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET 
Framework 4.0 and is implemented as a dynamic language in ***.
 */
class ForbiddenWords
{
    static void Main()
    {

        Console.Write("Enter a text: ");
        string textInput = Console.ReadLine();

        Console.Write("Enter a list of forbidden words, separated by SPACE: ");
        string[] forbiddenWords = Console.ReadLine().Split(' ');

        Console.WriteLine(ToAsterics(textInput, forbiddenWords));
    }
    static string ToAsterics(string textInput, string[] forbiddenWords)
    {
        
        string lookupWord = string.Empty;
        string substring = string.Empty;

        //loop through all of the forbidden words
        for (int forbiddenIndex = 0; forbiddenIndex < forbiddenWords.Length; forbiddenIndex++)
        {
            int startIndex = 0;
            lookupWord = forbiddenWords[forbiddenIndex];

            // loop through the the element to the end
            for (int i = startIndex; i < textInput.Length - lookupWord.Length; i++)
            {
                substring = textInput.Substring(i, lookupWord.Length);// get a substring from the text
                
                if (substring == lookupWord)// check for equality
                {
                    startIndex = i;
                    string asterix = new string('*', substring.Length);
                    string toReplace = textInput.Substring(startIndex, lookupWord.Length);// set part of the string to be replaced
                    textInput = textInput.Replace(toReplace, asterix);// store the replaced string
                }
            }
        }
        
        return textInput;
    }
}


