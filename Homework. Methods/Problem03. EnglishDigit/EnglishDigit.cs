using System;
/*
Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.
Examples:

input	output
512	    two
1024	four
12309	nine */
class EnglishDigit
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(LastDigit(number));
    }
    static string LastDigit (int number)
    {
        int digit = number % 10;
        string lastDigit = "";
        switch (digit)
        {
            case 0: lastDigit = "zero"; break;
            case 1: lastDigit = "one"; break;
            case 2: lastDigit = "two"; break;
            case 3: lastDigit = "three"; break;
            case 4: lastDigit = "four"; break;
            case 5: lastDigit = "five"; break;
            case 6: lastDigit = "six"; break;
            case 7: lastDigit = "seven"; break;
            case 8: lastDigit = "eight"; break;
            case 9: lastDigit = "nine"; break;
        }
        return lastDigit;
    }
}