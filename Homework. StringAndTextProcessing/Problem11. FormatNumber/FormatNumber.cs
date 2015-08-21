using System;
/*
 Problem 11. Format number

Write a program that reads a number and prints it as a decimal number, 
hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.
 */
class FormatNumber
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        string decimaNum = "Decimal";
        string hexNum = "Hexadecimal";
        string percentage = "Percentage";
        string notation = "Scientific Notation";

        Console.Write("{0,20}", decimaNum);
        Console.WriteLine("{0,15:D}", (int)number);

        Console.Write("{0,20}", hexNum);
        Console.WriteLine("{0,15:X}", (int)number);

        Console.Write("{0,20}", percentage);
        Console.WriteLine("{0,15:P3}", number);

        Console.Write("{0,20}", notation);
        Console.WriteLine("{0,15:E}", number);
    }
}