using System;
using System.IO;
using System.Text;
/*
 Problem 9. Delete odd lines

Write a program that deletes from given text file all odd lines.
The result should be in the same file.
 */
class DeleteOddLines
{
    static void Main()
    {
        string[] evenLines;
        int lineNumber = 0;
        int evenCounter = 0;
        using (StreamReader stream = new StreamReader("OddLines.txt"))
        {
            string line = stream.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if (lineNumber % 2 == 0) // check the line whether it is odd or not
                {
                    evenCounter++;
                    line = stream.ReadLine();
                }
                else
                {
                    line = stream.ReadLine();
                }
            }
        }
        using (StreamReader stream = new StreamReader("OddLines.txt"))
        {
            evenLines = new string[evenCounter];// make an array
            string textLine = stream.ReadLine();

            evenCounter = 0;// set a line counter
            lineNumber = 0;
            while (textLine != null)
            {
                lineNumber++;
                if (lineNumber % 2 == 0) // check the line whether it is odd or not
                {
                    evenLines[evenCounter] = textLine;// fill up the array
                    textLine = stream.ReadLine();
                    evenCounter++;
                }
                else
                {
                    textLine = stream.ReadLine();
                }
            }
        }
        using (StreamWriter withoutOddLines = new StreamWriter("OddLines.txt"))// creates a new file to store the line numbers and the uncluded text)
        {
            for (int i = 0; i < evenLines.Length; i++)
            {
                withoutOddLines.WriteLine("{0}", evenLines[i]);
            }
        }
    }
}
