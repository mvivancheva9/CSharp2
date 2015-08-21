using System;
using System.IO;
using System.Text.RegularExpressions;
/*
 Problem 13. Count words

Write a program that reads a list of words from the file words.txt and finds how many times each of the 
words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their 
occurrences in descending order.
Handle all possible exceptions in your methods.
 */
class CountWords
{
    static void Main()
    {
        int lineText = 0;
        try
        {
            string[] wordList = File.ReadAllLines("Words.txt");
            int[] wordCount = new int[wordList.Length];

            using (StreamReader stream = new StreamReader("Test.txt"))
            {
                string line = stream.ReadLine();
                while (line != null)
                {
                    lineText++;
                    for (int index = 0; index < wordList.Length; index++)
                    {
                        wordCount[index] += ((Regex.Matches(line, @"\b" + wordList[index] + @"\b").Count));
                    }
                    line = stream.ReadLine();
                }
            }
            Array.Sort(wordCount, wordList);
            using (StreamWriter countedWords = new StreamWriter("Result.txt"))// creates a new file to store the line numbers and the uncluded text)
            {
                for (int i = wordList.Length - 1; i >= 0; i--)
                {
                    countedWords.WriteLine("{0}: {1} time(s).", wordList[i], wordCount[i]);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not Found");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not Found");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Unauthorized Access");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Empty file");
        }
        catch (FileLoadException)
        {
            Console.WriteLine("Problem Loading File");
        }
    }
}