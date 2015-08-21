using System;
class SayHello
/*
 Problem 1. Say Hello

Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
Example:

input	output
Peter	Hello, Peter!
 */
{
    static void Main()
    {
        SayHi();// Call method SayHi
    }
    //declare method SayHi
    static void SayHi()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Hello, {0}!", name);
    }
}