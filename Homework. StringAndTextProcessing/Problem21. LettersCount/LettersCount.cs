using System;
/*
 Problem 21. Letters count

Write a program that reads a string from the console and prints all different letters
in the string along with information how many times each letter is found.
 */
class LettersCount
{
    static void Main()
    {
        Console.Write("Enter some text to search for letters: ");
        string text = Console.ReadLine();
        char desiredtLetter = ' ';
        char currentLetter = ' ';
        int counter = 0;
        char[] symbol = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j  < text.Length; j ++)
            {
                if ((text[i] >= 'A' && text[i] <= 'Z') || (text[i] >= 'a' && text[i] <= 'z'))// check of the current element is letter
                {
                    desiredtLetter = text[i];
                    currentLetter = text[j];

                    if (currentLetter == desiredtLetter)
                    {
                        counter++;// increase the counter in case of equality
                    }
                }
            }
            bool equality = false;
            for (int symbolIndex = 0; symbolIndex < symbol.Length; symbolIndex++)// loop through the array of the symbols
            {
                equality = false;
                if (desiredtLetter == symbol[symbolIndex])// if there is already such letter
                {
                    equality = true;
                    break;
                }
                else
                {
                    equality = false;
                }
            }
                if (equality == false)// if there is no such letter yet
                {
                    Console.Write(desiredtLetter);// printing
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
