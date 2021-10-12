using System;

namespace TimeOnlySample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TimeOnly Samples");
            Console.WriteLine();

            // TimeOnly is a new type in .NET 6. Stores a time without a date.
            TimeOnly tenThirtyPM = new TimeOnly(22, 30); // 22:30, or 10:30 PM
            Console.WriteLine($"TimeOnly: {tenThirtyPM}");
            TimeOnly nineTwentyFiveAM = new(9, 25, 10); // 09:25:10, or 9:25:10 AM
            Console.WriteLine($"TimeOnly: {nineTwentyFiveAM}");
            Console.WriteLine();

            // TimeOnly stores the value as a long (is the number of ticks since midnight)
            TimeOnly elevenTen = new TimeOnly(11, 10);
            long ticks = elevenTen.Ticks;
            TimeOnly timeOnlyTicks = new TimeOnly(ticks);
            Console.WriteLine($"TimeOnly from Ticks: {timeOnlyTicks}");
            Console.WriteLine();

            // Can get TimeOnly instance from a DateTime using TimeOnly.FromDateTime
            DateTime dateTime = new DateTime(2020, 12, 12, 8, 00, 00);
            TimeOnly timeOnlyFromDateTime = TimeOnly.FromDateTime(dateTime);
            Console.WriteLine($"Get TimeOnly instance from a DateTime using TimeOnly.FromDateTime: {timeOnlyFromDateTime}");
            Console.WriteLine();

            // Of course, we can perform math operations
            var afternoon = new TimeOnly(17, 00); // 5:00 PM
            var morning = new TimeOnly(8, 00); // 8:00 AN
            TimeSpan difference = afternoon - morning; // 9 hours
            Console.WriteLine($"Difference: {difference.Hours} hours");
            Console.WriteLine();

            // Also we can do comparisons between different TimeOnly instances
            var now = TimeOnly.FromDateTime(DateTime.Now);

            if (now.IsBetween(morning, afternoon))
                Console.WriteLine("Working!");
            else
                Console.WriteLine("Doing other stuff."); 
            
            Console.WriteLine();
        }
    }
}
