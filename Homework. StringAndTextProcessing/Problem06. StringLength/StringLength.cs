using System;
/*
 Problem 6. String length

Write a program that reads from the console a string of maximum 20 characters. 
If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.
 */
class StringLength
{
    static void Main()
    {
        Console.WriteLine("Enter a text: ");
        string input = Console.ReadLine();

        if (input.Length > 20)// check the length of the input text
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write(input[i]);// print the fisrt 20
            }
            Console.WriteLine();
        }
        else 
        {
            Console.Write(input);
            for (int i = input.Length; i < 20; i++)
            {
                Console.Write("*");// add * when the length of the input is less than 20
            }
            Console.WriteLine();
        }
        
    }
}
