using System;
/*
 Problem 2. Binary to decimal

Write a program to convert binary numbers to their decimal representation.
 */
class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a number in binary format: ");
        string binNum = Console.ReadLine();

        Console.Write("Decimal Representation: ");
        Console.WriteLine(ToDecimal(binNum));
    }
    static long ToDecimal (string binNum)
    {
        long decNum = 0;
        for (int i = 0; i < binNum.Length; i++)
        {
            long position = binNum.Length - i - 1;
            decNum += (binNum[i] - 48) * (long)Math.Pow(2, position);
        }
        return decNum;
    }
}
