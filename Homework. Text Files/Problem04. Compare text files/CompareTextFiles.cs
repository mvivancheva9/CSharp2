using System;
using System.IO;
/*
 Problem 4. Compare text files

Write a program that compares two text files line by line and prints the number of lines 
that are the same and the number of lines that are different.
Assume the files have equal number of lines.
 */
class CompareTextFiles
{
    static void Main()
    {
        using (StreamReader firstText = new StreamReader("FirstText.txt"))// read the first text
        {
            using (StreamReader secondText = new StreamReader("SecondText.txt"))// read the second text
            {
                int counterEqual = 0;// set ocunter for the equal lines
                int counterDifferent = 0;// set counter for the different lines

                string firstTextLine = firstText.ReadLine();
                string secondTextLine = secondText.ReadLine();

                while (firstTextLine != null && secondTextLine != null)// check for null lines
                {
                    if (firstTextLine.CompareTo(secondTextLine) == 0)// if lines are equal
                    {
                        counterEqual++;
                    }
                    else// if lines are different
                    {
                        counterDifferent++;
                    }
                    firstTextLine = firstText.ReadLine();
                    secondTextLine = secondText.ReadLine();
                }
                Console.WriteLine("Equal Lines: {0}", counterEqual);// printing
                Console.WriteLine("Different Lines: {0}", counterDifferent);
            }
        }

    }
}