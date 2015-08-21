using System;
/*
 Problem 5. Parse tags

You are given a text. Write a program that changes the text in all regions surrounded by the 
tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */
class ParseTags
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string textInput = Console.ReadLine();

        Console.WriteLine("To UPPER text:");
        Console.WriteLine(ToUpper(textInput));
    }
    static string ToUpper ( string textInput)
    {
        int startIndex = 0;
        for (int i = startIndex; i < textInput.Length; i++)
        {
            string openingPart = "<upcase>";
            string closingPart = "</upcase>";
            startIndex = textInput.IndexOf(openingPart, i);// set the start index for the substring
            if (startIndex == -1)
            {
                break;
            }
            int endIndex = textInput.IndexOf(closingPart, startIndex);// set the final index for the substring
            string upperCase = string.Empty;
            upperCase = textInput.Substring(startIndex + 8, endIndex - (startIndex + 8)).ToUpper();// extract the string between the two indexes
            i = startIndex;

            string toReplace = textInput.Substring(startIndex, endIndex - startIndex + 9);// set part of the string to be replaced
            textInput = textInput.Replace(toReplace, upperCase);// store the replaced string
        }
        return textInput;
    }
}