using System;
/*
 Problem 8. Binary short

Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
 */
class BinaryToShort
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        short shortNum = short.Parse(Console.ReadLine());

        Console.Write("Binary Representation: ");
        Console.WriteLine(ToBinary(shortNum));
    }
    static string ToBinaryAbsolute(short shortNum)
    {
        shortNum = Math.Abs(shortNum);
        long remainder = 0;
        string binaryNum = "";
        while (shortNum > 0)
        {
            remainder = shortNum % 2;
            binaryNum = remainder + binaryNum;
            shortNum = (short)(shortNum / 2);
        }
        binaryNum = binaryNum.PadLeft(16, '0');
        return binaryNum;
    }
    static string ToBinary(short shortNum)
    {
        string binaryNum = "";
        if(shortNum >= 0)
        {
            binaryNum = ToBinaryAbsolute(shortNum);
        }
        else
        {
            shortNum = (short)((Math.Abs(shortNum) - 1) * (-1));
            string binaryNegative = "";
            binaryNum = ToBinaryAbsolute(shortNum);
            for (int i = 0; i < binaryNum.Length; i++)
            {
                int currentDigit = (binaryNum[i] - 48);
                if (currentDigit == 0)
                {
                    currentDigit = 1;
                    binaryNegative += currentDigit;
                }
                else
                {
                    currentDigit = 0;
                    binaryNegative += currentDigit;
                }
            }
            binaryNum = binaryNegative;
        }
        return binaryNum;
    }
}
