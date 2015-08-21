using System;
using System.Text;
/*
 Problem 25. Extract text from HTML

Write a program that extracts from given HTML file its title (if available), 
and its body text without the HTML tags.
Example input:

<html><head><title>News</title></head><body><p><a href="http://academy.telerik.com">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>
 */
class ExtractTextFromHtml
{
    static void Main()
    {
        Console.Write("Enter a text: ");
        string textInput = Console.ReadLine();

        Console.Write("TITLE: ");
        Title(textInput);

        Console.Write("BODY:");
        Console.WriteLine(Body(textInput));
    }
    static void Title(string textInput)
    {
        int startIndex = 0;
        for (int i = startIndex; i < textInput.Length; i++)
        {
            string openingPart = "<title>";
            string closingPart = "</title>";
            startIndex = textInput.IndexOf(openingPart, i);// set the start index for the substring
            if (startIndex == -1)
            {
                break;
            }
            int endIndex = textInput.IndexOf(closingPart, startIndex);// set the final index for the substring
            string title = string.Empty;
            title = textInput.Substring(startIndex + 7, endIndex - (startIndex + 7));// extract the string between the two indexes
            i = startIndex;
            Console.WriteLine(title);
        }
    }
    static StringBuilder Body (string textInput)
    {
        StringBuilder output = new StringBuilder();//set a stringBuilder to hold the text
        string line = string.Empty;
        bool inTag = false;// variable used to extract the text, not in tags
        int startIndex = 0;
        int bodyStart = 0;
        int endIndex = 0;
        string openingPart = string.Empty;
        string closingPart = string.Empty;

        for (int i = startIndex; i < textInput.Length; i++)
        {
            openingPart = "<body>";
            closingPart = "</body>";
            startIndex = textInput.IndexOf(openingPart, i);// set the start index for the substring
            if (startIndex == -1)
            {
                break;
            }
            endIndex = textInput.IndexOf(closingPart, startIndex);// set the final index for the substring
            i = startIndex;
            bodyStart = startIndex;
            line = textInput.Substring(bodyStart + 6, endIndex - (bodyStart + 6));// extract the string between the two indexes
            
        }
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
        return output;
    }
}