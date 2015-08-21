using System;
using System.IO;
using System.Text;
/*
 Problem 10. Extract text from XML

Write a program that extracts from given XML file all the text without the tags.
Example:

<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3">
<interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
 */
class ExtractTextFromXML
{
    static void Main()
    {
        int lineNumber = 0;
        bool inTag = false;// variable used to extract the text, not in tags
        StringBuilder output = new StringBuilder();//set a stringBuilder to hold the text
        using (StreamReader streamXML = new StreamReader("Text.XML"))
        {
            string line = streamXML.ReadLine();
            while (line != null)
            {
                lineNumber++;

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '>')
                    {
                        inTag = false;
                        continue;
                    }
                    if (inTag)
                    {
                        continue;
                    }
                    if (line[i] == '<')
                    {
                        output.Append(' ');
                        inTag = true;
                        continue;
                    }
                    output.Append(line[i]);// attach the text to the stringBuilder
                }
                line = streamXML.ReadLine();
            }
            Console.WriteLine(output.ToString());
        }
    }
}
