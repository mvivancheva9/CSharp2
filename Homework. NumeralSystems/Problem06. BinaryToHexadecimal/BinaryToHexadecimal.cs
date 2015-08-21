using System;
/*
 
 Problem 6. Binary to hexadecimal

Write a program to convert binary numbers to hexadecimal numbers (directly).
 
 */
class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a number in binary format: ");
        string binNum = Console.ReadLine();

        Console.Write("Hexadecimal Representation: ");
        Console.WriteLine(BinToHex(binNum));
    }
    static string BinToHex(string binNum)
    {
        string hexNum = "";

        for (int i = 0; i < binNum.Length; i += 4)
        {
            switch (binNum.Substring(i, 4))
            {
                case "0000": hexNum += "0"; break;
                case "0001": hexNum += "1"; break;
                case "0010": hexNum += "2"; break;
                case "0011": hexNum += "3"; break;
                case "0100": hexNum += "4"; break;
                case "0101": hexNum += "5"; break;
                case "0110": hexNum += "6"; break;
                case "0111": hexNum += "7"; break;
                case "1000": hexNum += "8"; break;
                case "1001": hexNum += "9"; break;
                case "1010": hexNum += "A"; break;
                case "1011": hexNum += "B"; break;
                case "1100": hexNum += "C"; break;
                case "1101": hexNum += "D"; break;
                case "1110": hexNum += "E"; break;
                case "1111": hexNum += "F"; break;
                default: break;
            }
        }

        return hexNum;
    }
}
