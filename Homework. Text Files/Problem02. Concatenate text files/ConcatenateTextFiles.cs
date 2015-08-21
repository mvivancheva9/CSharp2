using System;
using System.IO;
/*
 Problem 2. Concatenate text files

Write a program that concatenates two text files into another text file.
 */
class ConcatenateTextFiles
{
    static void Main()
    {
        using (StreamWriter concatenatedText = new StreamWriter("ConcatenatedText.txt", true))
        {
            using (StreamReader firstText = new StreamReader("FirstText.txt"))// read the first text
            {
                string line = firstText.ReadLine();
                while (line != null)
                {
                    concatenatedText.WriteLine(line);// write it to the concatenated file
                    line = firstText.ReadLine();
                }
            }

            using (StreamReader secondText = new StreamReader("SecondText.txt"))// read the second text
            {
                string line = secondText.ReadLine();
                while (line != null)
                {
                    concatenatedText.WriteLine(line);// add it to the concatenated file
                    line = secondText.ReadLine();
                }
            }
        }
    }
}