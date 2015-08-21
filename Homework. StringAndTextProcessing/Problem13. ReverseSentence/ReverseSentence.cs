using System;
using System.Text;
/*
 Problem 13. Reverse sentence

Write a program that reverses the words in given sentence.
Example:

input	output
C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!
 */
class ReverseSentence
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string textInput = Console.ReadLine();

        char[] delimiters = new char[] { ' ', '.', ',', '!', '?', '\"' };
        string[] words = textInput.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);// extract only the words
        Array.Reverse(words);
        string[] textOutput = PunctuationString(textInput).Split(' ');

        Console.WriteLine(ReversedText(words, textOutput));
    }
    static string PunctuationString(string textInput)
    {
        string textOutput = string.Empty;
        for (int i = 0; i < textInput.Length; i++)
        {
            if ((textInput[i] == ' ') || (textInput[i] == ',') || (textInput[i] == '.') ||
                (textInput[i] == '!') || (textInput[i] == '?') || (textInput[i] == '-'))
            {
                textOutput += textInput[i];
            }
        }
        return textOutput;// extract only the punctuation
    }

    static StringBuilder ReversedText(string[] words, string[] textOutput)
    {
        StringBuilder reversedText = new StringBuilder();// set a stringBuilder for the reversed sentence
        int i = 0;
        int j = 0;

        while (i < words.Length || j < textOutput.Length)
        {
            if (i < words.Length)
            {
                reversedText.Append(words[i]);
                reversedText.Append(' ');
                i++;
            }
            if (j < textOutput.Length)
            {
                reversedText.Append(textOutput[j].ToString());
                j++;
            }
        }
        reversedText.ToString();
        return reversedText;
    }
}