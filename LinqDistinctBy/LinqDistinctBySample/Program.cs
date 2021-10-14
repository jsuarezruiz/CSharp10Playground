using System;
using System.Linq;

namespace LinqDistinctBySample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq DistinctBy");
            Console.WriteLine();

            var places = new[]      
            {
                new Place() { Name = "Eiffel Tower", Country = "France" },
                new Place() { Name = "Statue of Liberty", Country = "USA" },
                new Place() { Name = "Golden Gate Bridge", Country = "USA" },
                new Place() { Name = "Mount Rushmore", Country = "USA" },
                new Place() { Name = "The Sonoran Desert", Country = "USA" },
                new Place() { Name = "Torre del Oro", Country = "Spain" },
            };

            var numbers = new[] { 1, 6, 1, 8, 7, 9, 1 };

            // This already exists in previous .NET versions
            var distinctNumbers = numbers.Distinct().ToArray();

            foreach (var number in distinctNumbers)
            {
                Console.WriteLine($"{number} ");
            }

            Console.WriteLine();

            // Previously, if you want to get a list of Places with unique Country, have to do it in two passes:
            // Get the distinct places
            // For each distinct place, query the collection and pick the First place whose country match.
            var distinctPlaces = places.DistinctBy(x => x.Country).OrderBy(x => x.Name);
            // This is now much easier using the DistinctBy method.

            foreach (var place in distinctPlaces)
            {
                Console.WriteLine($"{place.Name}");
            }

            Console.WriteLine();
        }
    }

    public class Place
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
