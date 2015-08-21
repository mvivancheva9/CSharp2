using System;
using System.Numerics;
/*
 Problem 10. N Factorial

Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
 */
class NFactoriel
{
    static void Main()
    {
        int[] numberToFactorate = new int[100];
        for (int i = 0; i < numberToFactorate.Length; i++)
        {
            numberToFactorate[i] = i + 1;
        }

        CalculateFactoriel(numberToFactorate);
    }

    static void CalculateFactoriel(int[] numberToFactorate)
    {
        for (int i = 0; i < numberToFactorate.Length; i++)
        {
            BigInteger factoriel = FactorielNumber(numberToFactorate[i]);
            Console.WriteLine(factoriel);
        }
    }

    static BigInteger FactorielNumber(int i)
    {
        BigInteger factoriel = i;
        while (i > 1)
        {
            factoriel *= i - 1;
            i--;
        }
        return factoriel;
    }

}