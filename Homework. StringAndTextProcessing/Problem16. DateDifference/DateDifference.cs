using System;
using System.Globalization;
/*
 Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days 
between them.
Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
 */
class DateDifference
{
    static void Main()
    {
        string format = "d.M.yyyy";//set the format for the input dates
        CultureInfo provider = CultureInfo.InvariantCulture;// set the cultureInfo provider
        Console.Write("Enter the first date: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), format, provider);

        Console.Write("Enter the second date: ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), format, provider);

        double distance = Math.Abs((firstDate - secondDate).TotalDays);// estimate the distance between the dates

        Console.WriteLine("Distance: {0} days", distance);
    }
}