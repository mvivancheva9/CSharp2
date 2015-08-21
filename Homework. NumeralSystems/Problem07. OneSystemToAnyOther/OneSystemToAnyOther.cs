using System;
/*
 Problem 7. One system to any other

Write a program to convert from any numeral system of given base s to 
any other numeral system of base d (2 ≤ s, d ≤ 16).
 */
class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Enter value for the first base: ");
        int firstBase = int.Parse(Console.ReadLine());

        Console.Write("Enter value for the second base: ");
        int secondBase = int.Parse(Console.ReadLine());

        Console.Write("Enter value to convert: ");
        string valueToConvert = Console.ReadLine();

        Console.Write("The converted number is: ");
        Console.WriteLine(Conversion(firstBase, secondBase, valueToConvert));
    }

    static string Conversion(int firstBase, int secondBase, string valueToConvert)
    {
        //to decimal
        long decNum = 0;
        for (int i = 0; i < valueToConvert.Length; i++)
        {
            long position = valueToConvert.Length - i - 1;
            if (valueToConvert[i] >= '0' && valueToConvert[i] <= '9')
            {
                decNum += (valueToConvert[i] - 48) * (long)Math.Pow(firstBase, position);
            }
            else
            {
                decNum += (valueToConvert[i] - 'A' + 10) * (long)Math.Pow(firstBase, position);
            }
        }

        //from decimal to any other
        long remainder = 0;
        string otherNum = "";
        while (decNum > 0)
        {
            remainder = decNum % secondBase;
            if (remainder >= 0 && remainder <= 9)
            {
                otherNum = (char)(remainder + '0') + otherNum;
            }
            else
            {
                otherNum = (char)(remainder - 10 + 'A') + otherNum;
            }
            decNum = decNum / secondBase;
        }
        return otherNum;
    }
}