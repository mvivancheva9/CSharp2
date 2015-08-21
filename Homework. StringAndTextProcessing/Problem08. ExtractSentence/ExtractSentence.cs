using System;
/*
 Problem 8. Extract sentences

Write a program that extracts from a given text all sentences containing given word.
Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.
 */
class ExtractSentence
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string textInput = Console.ReadLine();

        Console.Write("Enter a lookup word: ");
        string word = Console.ReadLine();

        Sentence(textInput, word);
    }
    static string Sentence(string textInput, string word)
    {
        string sentence = string.Empty;
        int startIndex = 0;
        for (int i = startIndex; i < textInput.Length; i++)
        {
            string openingPart = "";
            string closingPart = ".";
            startIndex = textInput.IndexOf(openingPart, i);// set the start index for the substring
            if (startIndex == -1)
            {
                break;
            }
            int endIndex = textInput.IndexOf(closingPart, startIndex);// set the final index for the substring
            sentence = string.Empty;
            sentence = textInput.Substring(startIndex, (endIndex) - (startIndex - 1));// extract the string between the two indexes
            SubstringCheck(sentence, word);
            i = endIndex + 1;
        }
        return sentence;
    }
    static void SubstringCheck(string sentence, string word)
    {
        char[] separators = { ' ', ',', '.' };
        for (int j = 0; j < separators.Length; j++)
        {
            string lookupWord = " " + word + separators[j];// set the lookup word in the correct format
            for (int i = 0; i < sentence.Length - lookupWord.Length + 1; i++)// loop through the elements
            {
                string substring = sentence.Substring(i, lookupWord.Length);// get a substring from the text

                if (substring == lookupWord)// check for equality
                {
                    Console.WriteLine(sentence);
                }
            }
        }
        
    }
}
