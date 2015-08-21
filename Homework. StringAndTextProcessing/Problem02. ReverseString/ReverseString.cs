using System;
using System.Text;
/*
 Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
Example:

input	output
sample	elpmas
 */
class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        StringBuilder reversedString = new StringBuilder();// set a strignBuilder to have the reveresed string

        for (int i = input.Length - 1; i >= 0; i--)// loop throught the string
        {
            reversedString.Append(input[i]);// append each char to the stringBuilder
        }
        Console.WriteLine("Reversed String: {0}", reversedString);
    }
}