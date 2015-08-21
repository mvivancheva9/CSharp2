using System;
/*
 Problem 2. Random numbers

Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */

class RandomNumbers
{
    static void Main()
    {
        Random random = new Random();// using Random class to create a new variable
        for (int i = 0; i < 10; i++)// loop to print 10 results
        {
            Console.WriteLine(random.Next(100, 201));// set the range & print
        }
    }
}