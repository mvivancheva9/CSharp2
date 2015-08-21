using System;
/*
 Problem 3. Decimal to hexadecimal

Write a program to convert decimal numbers to their hexadecimal representation.
 */
class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a number in deccimal format: ");
        long decNum = long.Parse(Console.ReadLine());

        Console.Write("Hexadecimal Representation: ");
        Console.WriteLine(ToHexadecimal(decNum));
    }
    static string ToHexadecimal(long decNum)
    {
        long remainder = 0;
        string hexadecimalNum = "";
        while (decNum > 0)
        {
            remainder = decNum % 16;
            if ( remainder >= 0 && remainder <=9)
            {
                hexadecimalNum = (char)(remainder + '0') + hexadecimalNum;
            }
            else if (remainder >=10 && remainder <=15)
            {
                hexadecimalNum = (char)(remainder - 10 + 'A') + hexadecimalNum;
            }
            decNum = decNum / 16;
        }
        return hexadecimalNum;
    }
}
