using System;
/*
 Problem 11. Adding polynomials

Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
Example:

x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
 */
class AddingPolynomials
{
    static void Main()
    {
        int[] firstPolynomial = EnterPolynomials();
        int[] secondPolynomial = EnterPolynomials();
        AddPolynomials(firstPolynomial, secondPolynomial);
    }
    static int[] EnterPolynomials ()
    {
       
        Console.Write("Enter value for the power of the polynomial: ");
        int power = int.Parse(Console.ReadLine());
        int[] coefficients = new int[power + 1];

        for (int i = power; i >= 0; i--)
        {
            Console.Write("Coefficient for x^{0} = ", i);
            coefficients[i] = int.Parse(Console.ReadLine()); 
        }
        return coefficients;
    }
    static void AddPolynomials (int[] firstPolynomial, int[] secondPolynomial)
    {
        int minLength;
        int[] betterPolynomial;
        if (firstPolynomial.Length > secondPolynomial.Length)
        {
            minLength = secondPolynomial.Length;
            betterPolynomial = firstPolynomial;
        }
        else
        {
            minLength = firstPolynomial.Length;
            betterPolynomial = secondPolynomial;
        }
        int[] finalPolynomial = new int[betterPolynomial.Length];
        for (int i = betterPolynomial.Length - 1; i >= 0 ; i--)
        {
            while (i > minLength - 1)
            {
                finalPolynomial[i] = betterPolynomial[i];
                i--;

            }
            finalPolynomial[i] = firstPolynomial[i] + secondPolynomial[i];
        }
        PrintPolynomial(finalPolynomial);
        
    }
    static void PrintPolynomial (int[] finalPolynomial)
    {
        foreach (var item in finalPolynomial)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}

