using System;
using System.Collections.Generic;

namespace PriorityQueueSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PriorityQueue Sample");
            Console.WriteLine();

            var persons = new Queue<Person>();

            persons.Enqueue(new Person() { Name = "Javier" });
            persons.Enqueue(new Person() { Name = "David" });
            persons.Enqueue(new Person() { Name = "Pedro" });
            persons.Enqueue(new Person() { Name = "Jesus" });

            Console.WriteLine($"Using Queue");

            while (persons.TryDequeue(out var person))
            {
                Console.WriteLine($"Popping {person.Name}");
            }

            Console.WriteLine();

            // Each element is enqueued with an associated priority that determines the dequeue order: elements with the lowest priority get dequeued first.
            // We use a type to enqueue and a another type to use for the prioritization.
            var prioritizedAgents = new PriorityQueue<Person, int>();

            prioritizedAgents.Enqueue(new Person() { Name = "Javier" }, 36);
            prioritizedAgents.Enqueue(new Person() { Name = "David" }, 45);
            prioritizedAgents.Enqueue(new Person() { Name = "Pedro" }, 41); 
            prioritizedAgents.Enqueue(new Person() { Name = "Jesus" }, 33);

            Console.WriteLine($"Using PriorityQueue");

            while (prioritizedAgents.TryDequeue(out var person, out var age))
            {
                Console.WriteLine($"Popping {person.Name}, age {age}");
            }

            Console.WriteLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
