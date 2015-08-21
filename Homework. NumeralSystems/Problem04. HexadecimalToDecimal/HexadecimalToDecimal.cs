using System;
/*
 Problem 4. Hexadecimal to decimal

Write a program to convert hexadecimal numbers to their decimal representation.
 */
class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter a number in hexadecimal format: ");
        string hexNum = Console.ReadLine();

        Console.Write("Decimal Representation: ");
        Console.WriteLine(ToDecimal(hexNum));
    }
    static long ToDecimal(string hexNum)
    {
        long decNum = 0;
        for (int i = 0; i < hexNum.Length; i++)
        {
            long position = hexNum.Length - i - 1;
            if (hexNum[i] >= '0' && hexNum[i] <= '9')
            {
                decNum += (hexNum[i] - 48) * (long)Math.Pow(16, position);
            }
            else if (hexNum[i] >= 'A' && hexNum[i] <= 'F')
            {
                decNum += (hexNum[i] - 'A' + 10) * (long)Math.Pow(16, position);
            }
        }
        return decNum;
    }
}
