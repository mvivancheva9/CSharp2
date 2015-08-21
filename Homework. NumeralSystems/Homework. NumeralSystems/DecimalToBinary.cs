using System;
/*
 Problem 1. Decimal to binary

Write a program to convert decimal numbers to their binary representation.
 */
class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a number in deccimal format: ");
        long decNum = long.Parse(Console.ReadLine());

        Console.Write("Binary Representation: ");
        Console.WriteLine(ToBinary(decNum));
    }
    static string ToBinary(long decNum)
    {
        long remainder = 0;
        string binaryNum = "";
        while (decNum > 0)
        {
            remainder = decNum % 2;
            binaryNum = remainder + binaryNum;
            decNum = decNum / 2;
        }
        return binaryNum;
    }
}
