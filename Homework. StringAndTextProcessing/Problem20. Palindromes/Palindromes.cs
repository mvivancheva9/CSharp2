using System;
/*
 Problem 20. Palindromes

Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
 */
class Palindromes
{
    
        static char[] delimiters = new char[] { ' ', '.', ',', '!', '?', '\"' };
        static void Main(string[] args)
        {
            Console.Write("Enter some text to search for palindromes: ");
            string text = Console.ReadLine();
            string[] words = text.Split(delimiters,StringSplitOptions.RemoveEmptyEntries);// extract only the words

            for (int i = 0; i < words.Length; i++)
            {
                if ((IsPalindrome(words[i])) && words[i].Length > 1)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }

        static bool IsPalindrome(string word)
        {
            word = word.ToLower();
            for (int i = 0; i < word.Length/2; i++)// loop through the letters of the word
            {
               if ((word[i] == word[word.Length - 1 - i]))
                    {
                        continue;
                    }
               else
               {
                   return false;
               }
            }
            return true;
        }

    }