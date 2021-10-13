using System;

namespace ConstantInterpolatedStringsSample
{
    internal class Program
    {
        const string Scheme = "https"; 
        const string Home = "home";

        // Before  
        //const string Environment = Scheme + "://localhost:5002";
        //const string HomeUri = Environment + "/" + Home;

        // Now, with C# 10 we can use constant string interpolation
        const string Environment = $"{Scheme}://localhost:5002";
        const string HomeUri = $"{Environment}/{Home}";

        static void Main(string[] args)
        {
            Console.WriteLine($"Constant Interpolated Strings {HomeUri}");
        }
    }
}
