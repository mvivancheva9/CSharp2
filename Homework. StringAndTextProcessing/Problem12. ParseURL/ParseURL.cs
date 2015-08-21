using System;
/*
 Problem 12. Parse URL

Write a program that parses an URL address given in the format: 
[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Example:

URL	Information
http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
[server] = telerikacademy.com 
[resource] = /Courses/Courses/Details/212
 */
class ParseURL
{
    static void Main()
    {
        Console.Write("Enter URL: ");
        string url = Console.ReadLine();

        ExtractProtocol(url);

    }
    static void ExtractProtocol(string url)
    {
        string closingPart = ":";
        string protocol = string.Empty;
        int endIndex = url.IndexOf(closingPart);// set the final index for the substring

        for (int i = 0; i < endIndex; i++)
        {
            protocol += url[i];
        }
        Console.WriteLine("[protocol] = {0}", protocol);
        endIndex = endIndex + 3;
        ExtractServer(url, endIndex);
    }
    static void ExtractServer(string url, int endIndex)
    {
        int startIndex = endIndex;
        string closingPart = "/";
        string server = string.Empty;
        endIndex = url.IndexOf(closingPart, startIndex); // set the final index for the substring

        for (int i = startIndex; i < endIndex; i++)
        {
            server += url[i];
        }
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", url.Substring(endIndex));// print the rest
    }
}