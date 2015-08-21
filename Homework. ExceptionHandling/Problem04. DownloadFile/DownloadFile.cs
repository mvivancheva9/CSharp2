using System;
using System.Net;
using System.IO;
/*
 Problem 4. Download file

Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
 */
class DownloadFile
{
    static void Main()
    {
        string URL = "http://http://funny-pics-fun.com/wp-content/uploads/Very-Funny-Animal-Faces.jpg";
        string fileName = Path.GetFileName(URL);

        using (WebClient myWebClient = new WebClient())
        {
             try
            {
                myWebClient.DownloadFile(URL, fileName);
                Console.WriteLine("Download successful");
            }
             catch (WebException exception)
             {
                 Console.WriteLine(exception.Message);
             }
             catch (ArgumentException exception)
             {
                 Console.WriteLine(exception.Message);
             }
             catch (NotSupportedException exception)
             {
                 Console.WriteLine(exception.Message);
             }
        }
    }
}