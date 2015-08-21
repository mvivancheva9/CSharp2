using System;
using System.IO;
/*
 Problem 1. Odd lines

Write a program that reads a text file and prints on the console its odd lines.
 */
class OddLines
{
    static void Main()
    {
        using (StreamReader stream = new StreamReader("OddLines.txt"))
        {
            int lineNumber = 0;
            string line = stream.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if (lineNumber % 2 == 1) // check the line whether it is odd or not
                {
                    Console.WriteLine("{0}",line);// print the line
                }
                line = stream.ReadLine();
            }

        }
    }
}