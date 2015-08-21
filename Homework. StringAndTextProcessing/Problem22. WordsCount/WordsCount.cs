using System;
/*
 Problem 22. Words count

Write a program that reads a string from the console and lists all 
different words in the string along with information how many times each word is found.
 */
class WordsCount
{
    static char[] delimiters = new char[] { ' ', '.', ',', '!', '?', '\"' };
    static void Main()
    {
        Console.Write("Enter some text to search for words: ");
        string[] text = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);// extract only the words
        string desiredtWord = string.Empty;
        string currentWord = string.Empty;
        int counter = 0;
        string[] symbol = new string[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < text.Length; j++)
            {
                desiredtWord = text[i];
                currentWord = text[j];

                if (currentWord == desiredtWord)
                {
                    counter++;// increase the counter in case of equality
                }
            }
            bool equality = false;
            for (int symbolIndex = 0; symbolIndex < symbol.Length; symbolIndex++)// loop through the array of the words
            {
                equality = false;
                if (desiredtWord == symbol[symbolIndex])// if there is already such word
                {
                    equality = true;
                    break;
                }
                else
                {
                    equality = false;
                }
            }
            if (equality == false)// if there is no such word yet
            {
                Console.Write(desiredtWord);// printing
                Console.WriteLine(" - {0} times", counter);
                counter = 0;
                symbol[i] = text[i];
            }
            else
            {
                counter = 0;
            }
        }
    }
}
