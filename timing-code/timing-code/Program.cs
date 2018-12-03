using System;
using System.Diagnostics;

namespace timing_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();

            // Begin testing code
            Console.WriteLine("Hello World!");
            // End testing code

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            Console.WriteLine($"Ran in {ts.TotalMilliseconds} milliseconds.");
        }
    }
}
