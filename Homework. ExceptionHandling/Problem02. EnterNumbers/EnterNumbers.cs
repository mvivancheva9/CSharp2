using System;
/*
 Problem 2. Enter numbers

Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */
class EnterNumbers
{
    static void Main()
    {
        string name = Console.ReadLine();
        if (name == null)
        {
            throw new ArgumentNullException();
        }
        int start = 1;
        int stop = 100;

        for (int i = 0; i < 10; i++)// loop through the number of times to enter the number
        {
            start = ReadNumber(start, stop);
        }
    }
    private static int ReadNumber(int start, int stop)
    {
        int number = 0;
        try
        {
            Console.Write("Enter number in range [{0}...{1}]: ", start, stop);
            number = int.Parse(Console.ReadLine());

            if (number <= start || number >= stop)
            {
                throw new ArgumentOutOfRangeException();// check whether the number is in the correct range & throw an exception
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid Number");
        }
        catch (FormatException)// if the number is not in the correct format
        {
            Console.WriteLine("Invalid Number");
        }
        return number;
    }
}
