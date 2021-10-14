using System;
using System.Linq;

namespace LinqChunkSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a 100 items array
            var range = Enumerable.Range(1, 100).ToArray();

            // Split the collection into chunks of 20
            var chunks = range.Chunk(size: 20).ToList();

            // Chunk() takes a size parameter and then split the collection into small collections with the number of elements as specified by the size.

            for (var i = 0; i < chunks.Count(); i++)
            {
                Console.WriteLine($"Chunk {i}");
                Console.WriteLine(string.Join(",", chunks[i]));
            }
        }
    }
}
