using System;
using System.IO;
using System.Text;
/*
 Problem 11. Prefix "test"

Write a program that deletes from a text file all words that start with the prefix test.
Words contain only the symbols 0…9, a…z, A…Z, _.
 */
class PrefixTest
{
    static void Main()
    {
        int lineNumber = 0;
        StringBuilder output = new StringBuilder();//set a stringBuilder to hold the text
        using (StreamReader stream = new StreamReader("Test.txt"))
        {
            string line = stream.ReadLine();
            while (line != null)
            {
                lineNumber++;
                    output.Append(line);
                    output = output.Replace("test", string.Empty);// replacing
                line = stream.ReadLine();
            }
        }
        using (StreamWriter withoutTest = new StreamWriter("Test.txt"))// creates a new file to store the line numbers and the uncluded text)
        {
            for (int i = 0; i < output.Length; i++)
            {
                withoutTest.Write("{0}", output[i]);
            }
        }
    }
}