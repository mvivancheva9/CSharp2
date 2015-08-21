using System;
using System.Globalization;
using System.Threading;
/*
 Problem 17. Date in Bulgarian

Write a program that reads a date and time given in the format: 
day.month.year hour:minute:second and prints the date and time 
after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 */
class DateInBulgarian
{
    static void Main()
    {
        string format = "d.M.yyyy H:m:s";//set the format for the input dates
        CultureInfo provider = CultureInfo.GetCultureInfo("BG-bg");// set the cultureInfo provider
        Console.Write("Enter the first date: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), format, provider);//enter the date and time

        DateTime currentDate = firstDate.AddHours(6).AddMinutes(30);// add 6 hours and 30 min
        string dayOfWeek = provider.DateTimeFormat.GetDayName(currentDate.DayOfWeek);// get the day of week

        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");// set the format of the output

        Console.WriteLine(currentDate);
        Console.WriteLine("{0}", dayOfWeek);
    }
}