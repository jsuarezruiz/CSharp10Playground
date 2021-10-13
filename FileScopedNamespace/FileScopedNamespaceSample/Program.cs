using System;

namespace FileScopedNamespaceSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { Name = "Javier", Age = 36 };

            Console.WriteLine($"FileScoped Namespaces {person.Name}");
        }
    }
}