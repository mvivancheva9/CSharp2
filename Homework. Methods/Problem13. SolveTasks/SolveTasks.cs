using System;
/*
 Problem 13. Solve tasks

Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
 */
class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Choose an option to solve a task:");
        Console.WriteLine("(1) Reverse the digits of a number!");
        Console.WriteLine("(2) Calculates the average of a sequence of integers!");
        Console.WriteLine("(3) Solves a linear equation a * x + b = 0!");
        Console.Write("Press (1), (2) or (3): ");
        int press = int.Parse(Console.ReadLine());

        if (press == 1)
        {
            ReversedInput();

        }
        if (press == 2)
        {
            AverageInput();
        }
        if (press == 3)
        {
            LinearEquation();
        }
    }
    static decimal Reversed(decimal number)
    {
            decimal reversedNumber;
            string reverse = "";
 
            string stringNumber = number.ToString();

            for (int i = stringNumber.Length - 1; i >= 0; i--)
            {
                reverse += stringNumber[i];
            }
            reversedNumber = decimal.Parse(reverse);
            Console.WriteLine(reversedNumber);
            return reversedNumber;
    }
    static void ReversedInput()
    {
        decimal number;
        Console.Write("Enter a number: ");
        bool convert = decimal.TryParse(Console.ReadLine(), out number);
        if (number < 0 || convert == false)
        {
            Console.WriteLine("Enter a valid number");
            ReversedInput();
        }
        else
        {
            Reversed(number);
        }
    }
    static void Average(string[] elements)
    {
        int[] sequenceOfElements = new int[elements.Length];

        for (int i = 0; i < elements.Length; i++)
        {
            sequenceOfElements[i] = int.Parse(elements[i]);
        }
        decimal sumOfElements = 0;
        for (int index = 0; index < sequenceOfElements.Length; index++)
        {
            sumOfElements += sequenceOfElements[index];
        }
        decimal average = sumOfElements / sequenceOfElements.Length;

        Console.WriteLine("Average: ");
        Console.WriteLine(average);
    }
    static void AverageInput ()
    {
        Console.WriteLine("Enter sequence of elements: ");
        string elements = Console.ReadLine();
        if (String.IsNullOrEmpty(elements))
        {
            Console.WriteLine("An empty sequence is not allowed!");
            AverageInput();
        }
        else
        {
            string[] arrayElements = elements.Split(' ');
            Average(arrayElements);
        }
    }
    static void LinearEquation()
    {
        int a = 0;
        while (a == 0)
        {
            Console.Write("Enter a number for the first coefficient, different from 0: ");
            a = int.Parse(Console.ReadLine());

        }
        Console.Write("Enter a number for the second coefficient: ");
        decimal b = int.Parse(Console.ReadLine());

        decimal x = -b / a;
        Console.WriteLine("The result of the equation is: {0}", x);
    }
}
