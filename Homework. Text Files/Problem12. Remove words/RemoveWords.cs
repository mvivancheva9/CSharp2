using System;
using System.IO;
using System.Text;
/*
 Problem 12. Remove words

Write a program that removes from a text file all words listed in given another text file.
Handle all possible exceptions in your methods.
 */
class RemoveWords
{
    static void Main()
    {
        int lineText = 0;
        int lineWord = 0;
        StringBuilder output = new StringBuilder();//set a stringBuilder to hold the text
        try
        {
            using (StreamReader stream = new StreamReader("Text.txt"))
            {
                string line = stream.ReadLine();
                while (line != null)
                {
                    lineText++;
                    output.Append(line);
                    using (StreamReader words = new StreamReader("Words.txt"))
                    {
                        string wordLine = words.ReadLine();
                        while (wordLine != null)
                        {
                            lineWord++;
                            output = output.Replace(wordLine, string.Empty);// replacing
                            wordLine = words.ReadLine();
                        }
                    }
                    line = stream.ReadLine();
                }
            }
            using (StreamWriter withoutTest = new StreamWriter("Text.txt"))// creates a new file to store the line numbers and the uncluded text)
            {
                for (int i = 0; i < output.Length; i++)
                {
                    withoutTest.Write("{0}", output[i]);
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