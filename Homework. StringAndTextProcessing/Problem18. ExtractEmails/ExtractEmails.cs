using System;
using System.Text.RegularExpressions;
/*
 Problem 18. Extract e-mails

Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */
class ExtractEmails
{
    static void Main()
    {
        Console.Write("Enter Text: ");
        string inputText = Console.ReadLine();

        string strRegex = @"[a-z0-9_\-\+\.]+[a-z0-9_\-\+]+@[a-z0-9\-]+\.([a-z]{2,3})(?:\.[a-z]{2})?";
        Regex myRegex = new Regex(strRegex, RegexOptions.None);

        foreach (Match myMatch in myRegex.Matches(inputText))
        {
            if (myMatch.Success)
            {
                Console.WriteLine(myMatch);
            }
        }
    }

}