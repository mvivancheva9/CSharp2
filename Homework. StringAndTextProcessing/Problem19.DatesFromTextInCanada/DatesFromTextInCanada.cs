using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
/*
 Problem 19. Dates from text in Canada

Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.
 */
class DatesFromTextInCanada
{
    static void Main()
    {
        Console.Write("Enter Text: ");
        string inputText = Console.ReadLine();

        string strRegex = "\\b(?<day>[\\d]{1,2})\\.(?<month>[\\d]{1,2})\\.(?<year>[\\d]{4})";
        Regex myRegex = new Regex(strRegex, RegexOptions.None);

        foreach (Match myMatch in myRegex.Matches(inputText))
        {
            if (myMatch.Success)
            {
                string date = myMatch.ToString();
                string format = "d.M.yyyy";//set the format for the input dates
                CultureInfo provider = CultureInfo.GetCultureInfo("en-CA");// set the cultureInfo provider
                DateTime theDate = DateTime.ParseExact(date, format, provider);
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");// set the format of the output
               
                Console.WriteLine(theDate.ToShortDateString());

            }
        }
    }
}