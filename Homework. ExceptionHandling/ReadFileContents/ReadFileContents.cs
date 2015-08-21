using System;
using System.IO;
/*
 Problem 3. Read file contents

Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
 */
class ReadFileContents
{
    static void Main()
    {
        Console.Write("Enter path: ");
        string path = Console.ReadLine();

        try
        {
            string content = File.ReadAllText(path);
            Console.WriteLine(content);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("No entry");
            Main();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No such file");
            Main();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
            Main();
        }
        catch (IOException)
        {
            Console.WriteLine("The file can't be opened");
            Main();
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("No access");
            Main();
        }

    }
}