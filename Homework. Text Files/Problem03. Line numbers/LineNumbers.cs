using System;
using System.IO;
/*
 Problem 3. Line numbers

Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.
 */
class LineNumbers
{
    static void Main()
    {
        using (StreamReader stream = new StreamReader("OddLines.txt"))// reads the original file
        {
            string textLine = stream.ReadLine();
            
            int lineCounter = 0;// set a line counter
            using (StreamWriter lineNumbers = new StreamWriter("LineNumbers.txt"))// creates a new file to store the line numbers and the uncluded text)
            {
                while (textLine != null)
                {
                    lineCounter++;
                    lineNumbers.WriteLine("Line {0}: {1}", lineCounter, textLine);// write the lines with their corresponding numbers
                    textLine = stream.ReadLine();
                }
            }
        }
    }
}