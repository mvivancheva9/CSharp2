using System;
/*
 Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */
class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter an expression: ");
        string expression = Console.ReadLine();

        Console.WriteLine(CheckBrackets(expression) ? "Correct" : "Incorrect");
    }

    static bool CheckBrackets(string expression)
    {

        int openBrackets = 0;//counter for the opening brackets
        int closeBrackets = 0;// counter for the closing brackets
        bool isEqual = true;// boolean variable for the equality

        for (int i = 0; i < expression.Length; i++)// loop to pass through all of the elements
        {
            if(expression[i] == '(')
            {
                openBrackets++; // increase the counter
            }
            else if (expression[i] == ')')
            {
                closeBrackets++;
            }
            if (expression[0] == ')')
            {
                isEqual = false;// check the first symbol of the equation
            }

        }
        if (openBrackets != closeBrackets)// check both counters
        {
            isEqual = false;
        }
        return isEqual;
    }
}