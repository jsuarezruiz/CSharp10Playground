using System;

namespace DateOnlySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DateOnly Samples");
            Console.WriteLine();

            // DateOnly is a new struct in .NET 6 that represents just a date.
            DateOnly july23th = new DateOnly(1985, 7, 23);
            Console.WriteLine($"DateOnly {july23th}"); // A DateOnly in the console shows the date using the current culture.
            DateOnly jan10th = new(1988, 1, 1);
            Console.WriteLine($"DateOnly {jan10th}");
            Console.WriteLine();

            // Can create DateOnly instances from DateTime instances using DateOnly.FromDateTime.
            DateTime dateTime = new DateTime(2000, 2, 14, 8, 05, 30);
            DateOnly dateOnlyFromDateTime = DateOnly.FromDateTime(dateTime); // Feb 14th, 2000
            Console.WriteLine($"DateOnly instance created from DateTime instance using DateOnly.FromDateTime: {dateOnlyFromDateTime}");
            Console.WriteLine();

            // Like with DateTime, we can add days, months, and years.
            dateOnlyFromDateTime = dateOnlyFromDateTime.AddYears(1).AddMonths(2).AddDays(15); // Apr 29th, 2001
            Console.WriteLine($"Adding days, months and years to DateOnly: {dateOnlyFromDateTime}");
            Console.WriteLine();

            // DateOnly stores the value as an integer (0 is January 1 0001).
            DateOnly dateOnlyInteger = new(1985, 7, 23); // Jul 23th 1985
            int dayNumber = dateOnlyInteger.DayNumber;
            DateOnly resultFromDayNumber = DateOnly.FromDayNumber(dayNumber);
            Console.WriteLine($"DayNumber: {dayNumber}, DateOnly from day number: {resultFromDayNumber}");                                                     
            Console.WriteLine();   
            
            // We can parse like uusing DateTime with the TryParse method.
            if (DateOnly.TryParse("01/21/2020", out DateOnly result))
            {
                Console.WriteLine($"Parsing from string: {result}"); // Jan 21th, 2020
                Console.WriteLine();
            }
        }
    }
}