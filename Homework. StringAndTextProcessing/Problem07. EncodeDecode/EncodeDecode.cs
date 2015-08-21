using System;
using System.Text;
/*
 Problem 7. Encode/decode

Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter
of the string with the first of the key, the second – with the second, etc. When the last key character is reached,
the next is the first.
 */
class EncodeDecode
{
    static void Main()
    {
        Console.Write("Enter a text to encode: ");
        string text = Console.ReadLine();

        Console.Write("Enter encryption key (cipher): ");
        string chiper = Console.ReadLine();
        StringBuilder encryptedText = new StringBuilder();// set a stringBuilder to add the ecrypted elements

        for (int i = 0; i < text.Length; i++)// loop to pass through every element in the text
        {
            encryptedText.Append((char)((int)text[i] ^ (int)chiper[i % chiper.Length]));// encrypt and add the element to the stringBuilder
        }
        encryptedText.ToString();
        Console.WriteLine(encryptedText);// print

    }
}