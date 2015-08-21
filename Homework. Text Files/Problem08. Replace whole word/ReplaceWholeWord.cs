using System;
using System.IO;
/*
 Problem 8. Replace whole word

Modify the solution of the previous problem to replace only whole words (not strings).
 */
class ReplaceWholeWord
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
                    string currentLine = lineToRead;
                    int beginIndex = currentLine.IndexOf("start");
                    int endIndex = beginIndex + 5;
                    int lineLength = currentLine.Length;
                    if (endIndex < lineLength)
                    {
                        if (beginIndex == 0)
                        {
                            if (currentLine[endIndex] == ' ' || currentLine[endIndex] == ',' || currentLine[endIndex] == '.' || currentLine[endIndex] == ';' || currentLine[endIndex] == ':' || currentLine[endIndex] == '-')
                            {
                                lineToRead = lineToRead.Replace("start", "finish");// replacing
                                streamWrite.WriteLine(lineToRead);// writing
                            }
                        }
                        else if ((currentLine[beginIndex - 1] == ' ' || currentLine[beginIndex - 1] == ',' || currentLine[beginIndex - 1] == '.' || currentLine[beginIndex - 1] == ';' || currentLine[beginIndex - 1] == ':' || currentLine[beginIndex - 1] == '-') &&
                        (currentLine[endIndex] == ' ' || currentLine[endIndex] == ',' || currentLine[endIndex] == '.' || currentLine[endIndex] == ';' || currentLine[endIndex] == ':' || currentLine[endIndex] == '-'))
                    
                        {
                            lineToRead = lineToRead.Replace("start", "finish");// replacing
                            streamWrite.WriteLine(lineToRead);// writing
                        }
                        else
                        {
                            streamWrite.WriteLine(lineToRead);// writing
                        }
                    }
                    else if(endIndex >= lineLength)
                    {
                        if (beginIndex == 0)
                        {
                            lineToRead = lineToRead.Replace("start", "finish");// replacing
                            streamWrite.WriteLine(lineToRead);// writing
                        }
                        else if (currentLine[beginIndex - 1] == ' ' || currentLine[beginIndex - 1] == ',' || currentLine[beginIndex - 1] == '.' || currentLine[beginIndex - 1] == ';' || currentLine[beginIndex - 1] == ':' || currentLine[beginIndex - 1] == '-')
                        {
                            lineToRead = lineToRead.Replace("start", "finish");// replacing
                            streamWrite.WriteLine(lineToRead);// writing
                        }
                        else
                        {
                            streamWrite.WriteLine(lineToRead);// writing
                        }
                    }
                }
            }
        }
    }
}
