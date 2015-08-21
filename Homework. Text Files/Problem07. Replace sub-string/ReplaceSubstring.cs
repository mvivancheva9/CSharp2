using System;
using System.IO;
/*
 Problem 7. Replace sub-string

Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).
 */
class ReplaceSubstring
{
    static void Main()
    {
        using (StreamReader streamRead = new StreamReader("Read.txt"))// read the file to change
        {
            using (StreamWriter streamWrite = new StreamWriter("Write.txt"))// create new file
            {
                string lineToRead = string.Empty;
                while ((lineToRead = streamRead.ReadLine()) != null)
                {
                    lineToRead = lineToRead.Replace("start", "finish");// replacing
                    streamWrite.WriteLine(lineToRead);// writing
                }
            }
        }
    }
}
