using System;


/*
 Problem 8. Number as array

Write a method that adds two positive integer numbers represented as arrays of digits 
(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
 */
class NumberAsArray
{
    static void Main()
    {
        int[] firstNumber = EnterSequenceNumber();
        int[] secondNumber = EnterSequenceNumber();

        Add(firstNumber, secondNumber);
    }

    static int[] EnterSequenceNumber()
    {
        Console.Write("Enter an integer number: ");
        string stringNumber = Console.ReadLine();
        int[] sequence = new int[stringNumber.Length];
        for (int i = 0; i < stringNumber.Length; i++)
        {
            sequence[i] = stringNumber[i] - 48;
        }
        Array.Reverse(sequence);
        return sequence;
    }
    static void Add(int[] firstNumber, int[] secondNumber)
    {
        int sum = 0;
        int remainder;
        int[] maxLength;
        int[] minLength;
        if(firstNumber.Length > secondNumber.Length)
        {
            maxLength = firstNumber;
            minLength = secondNumber;
        }
        else
        {
            maxLength = secondNumber;
            minLength = firstNumber;
        }
        string[] addedSequence = new string[ maxLength.Length + 1];
        for (int i = 0; i < maxLength.Length; i++)
        {
            
                sum = firstNumber[i] + secondNumber[i];
                remainder = sum % 10;
                addedSequence[i] += remainder;
            if (i < maxLength.Length - 1)
                {
                    maxLength[i + 1] += sum / 10;
                }
                else
                {
                    remainder = sum / 10;
                    addedSequence[i + 1] += remainder;
                }
        }
        Array.Reverse(addedSequence);
        if( addedSequence[0] == "0")
        {
            addedSequence[0] = null;
        }
        foreach (var item in addedSequence)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}