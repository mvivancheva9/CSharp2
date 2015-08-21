using System;

/*
 Problem 10. Unicode characters

Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
Example:

input	output
Hi!	\u0048\u0069\u0021
 */
class UnicodeCharacter
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Convert(input);
    }

    static void Convert (string input)
    {
        char currentSymbol = ' ';
        for (int i = 0; i < input.Length; i++)// loop through each symbol
        {
            currentSymbol = input[i];// set a variable

            Console.Write("\\u{0:x4}", (short)currentSymbol);// print the converted variable in the desire format
        }
        Console.WriteLine();
    }
}
