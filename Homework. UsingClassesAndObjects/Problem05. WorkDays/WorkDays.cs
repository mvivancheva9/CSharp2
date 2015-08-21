using System;

/*
 Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays 
specified preliminary as array.
 */
class WorkDays
{
    static DateTime[] holidays = {
                                    new DateTime(2015, 3, 1),
                                    new DateTime(2015, 3, 3),
                                    new DateTime(2015, 4, 10),
                                    new DateTime(2015, 4, 13), 
                                    new DateTime(2015, 5, 1),
                                    new DateTime(2015, 5, 6),
                                    new DateTime(2015, 9, 22),
                                    new DateTime(2015, 12, 24),
                                    new DateTime(2015, 12, 25),
                                };
    static void Main()
    {
        DateTime dateNow = DateTime.Now;

        Console.Write("Enter a month to check for working days: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter a day to check for working days: ");
        int day = int.Parse(Console.ReadLine());

        int year = 2015;

        DateTime endDate = new DateTime(year, month, day);

        Console.WriteLine("Working Days: {0}", DaysToWork(dateNow, endDate));
    }

    static int DaysToWork(DateTime dateNow, DateTime endDate)
    {
        int counter = 0;
        int workDays = (endDate - dateNow).Days;
        if (workDays < 0)
        {
            Console.WriteLine("Enter a date in the future");
        }
        else
        {
            counter = workDays;// set all days to be working
        }
        while (dateNow < endDate)
        {
            // check for weekends
            if (dateNow.DayOfWeek == DayOfWeek.Sunday || dateNow.DayOfWeek == DayOfWeek.Saturday)
            {
                counter--;
            }
            // check for holidays
            for (int days = 0; days < holidays.Length; days++)
            {
                if (dateNow.CompareTo(holidays[days]) == 0)
                {
                    counter--;
                }
            }
            dateNow = dateNow.AddDays(1);
        }
        return counter;
    }
}