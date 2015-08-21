using System;
/*
 Problem 1. Square root

Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
 */
class SquareRoot
{
    static void Main()
    {
        string name = string.Empty;
        try
        {
            name = Console.ReadLine();
            if (name == string.Empty)
            {
                name = "Alien";
                throw new ArgumentNullException();
                
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid name");
        }
        Console.WriteLine(name);
    }
}
