using System;
/*
 Problem 12. Subtracting polynomials

Extend the previous program to support also subtraction and multiplication of polynomials.
 */
class SubtractingPolynomials
{
    static void Main()
    {
        int[] firstPolynomial = EnterPolynomials();
        int[] secondPolynomial = EnterPolynomials();
        SubtractPolynomials(firstPolynomial, secondPolynomial);
        MultiplyPolynomials(firstPolynomial, secondPolynomial);
    }
    static int[] EnterPolynomials()
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
    static void SubtractPolynomials(int[] firstPolynomial, int[] secondPolynomial)
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
        for (int i = betterPolynomial.Length - 1; i >= 0; i--)
        {
            while (i > minLength - 1)
            {
                finalPolynomial[i] = betterPolynomial[i];
                i--;

            }
            finalPolynomial[i] = firstPolynomial[i] - secondPolynomial[i];
        }
        PrintPolynomial(finalPolynomial);

    }
    static void MultiplyPolynomials ( int[] firstPolynomial, int[] secondPolynomial)
    {
        int[] finalPolynomial = new int[firstPolynomial.Length + secondPolynomial.Length - 1];
        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            
            for (int j = 0; j < secondPolynomial.Length; j++)
            {
                
                int position = i + j;

                finalPolynomial[position] += (firstPolynomial[i] * secondPolynomial[j]);
            }
        }
        PrintPolynomial(finalPolynomial);
    }
    static void PrintPolynomial(int[] finalPolynomial)
    {
        foreach (var item in finalPolynomial)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}