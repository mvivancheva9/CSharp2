using System;
using System.IO;
/*
 Problem 6. Save sorted names

Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
Example:

input.txt	output.txt
Ivan        George 
Peter       Ivan 
Maria       Maria 
George	    Peter

 */
class SaveSortedNames
{
    static void Main()
    {
        int lineCounter = 0;// set a line counter
        using (StreamReader stream = new StreamReader("UnsortedNames.txt"))// reads the original file
        {
            
            string textLine = stream.ReadLine();
            while (textLine != null)// find the number of lines
            {
                lineCounter++;

                textLine = stream.ReadLine();
            }
        }
        using (StreamReader stream = new StreamReader("UnsortedNames.txt"))// reads the original file
        {
            string[] namesAsArray = new string[lineCounter];// make an array
            string textLine = stream.ReadLine();

            lineCounter = 0;// set a line counter

            while (textLine != null)
            {
                namesAsArray[lineCounter] = textLine;// fill up the array
                lineCounter++;
                textLine = stream.ReadLine();
            }
            Array.Sort(namesAsArray);// sort
            using (StreamWriter sortedNames = new StreamWriter("SortedNames.txt"))// creates a new file to store the line numbers and the uncluded text)
            {
                for (int i = 0; i < namesAsArray.Length; i++)
                {
                    sortedNames.WriteLine("{0}", namesAsArray[i]);// fill the new file
                }
            }
        }
    }
}
