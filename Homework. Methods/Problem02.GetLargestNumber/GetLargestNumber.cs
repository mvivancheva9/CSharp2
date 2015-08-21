using System;
/*
 Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
 */
class GetLargestNumber
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNum = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int thirdNum = int.Parse(Console.ReadLine());
        Console.Write("The largest number is: ");
        Console.WriteLine(GetMax(GetMax(firstNum, secondNum), thirdNum));// call the GetMax method
    }
    static int GetMax (int firstNum, int secondNum)//declare the GetMax method
{
    int maxNum = firstNum;
        if ( secondNum > maxNum)
        {
            maxNum = secondNum;
        }
        return maxNum;
}
}