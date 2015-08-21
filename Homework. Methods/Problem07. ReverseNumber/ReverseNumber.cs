using System;
/*
 Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.
Example:

input	output
256	    652
123.45	54.321
 */
class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        decimal number = decimal.Parse(Console.ReadLine());

        Console.Write("Reversed number: ");
        Console.WriteLine(Reversed(number));
    }

    static decimal Reversed (decimal number)
    {
        decimal reversedNumber;
        string reverse = "";

        string stringNumber = number.ToString();

        for (int i = stringNumber.Length - 1; i >= 0; i--)
        {
            reverse += stringNumber[i];
        }
        reversedNumber = decimal.Parse(reverse);
        return reversedNumber;
    }
}