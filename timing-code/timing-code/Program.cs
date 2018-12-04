using System;
using System.Diagnostics;

namespace timing_code
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static string Method1(string mystring)
        {
            return $"{mystring} is ok";
        }

        public static int Method2(string mystring)
        {
            return 2;
        }

        public static void RunTheMethod(Action myMethodName)
        {
            myMethodName();
        }

        static string Timer(Func<string, string> TestMethod)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();

            // Begin testing code
            string test = TestMethod("Aimee");
            // End testing code

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            Console.WriteLine($"Ran in {ts.TotalMilliseconds} milliseconds.");
        }

        for (int i = 1; 1 < length; i++) {
        
}
 
        //static string RunMethod(Func<string, string> MethodName, string name)
        //{
        //    string result = MethodName(name);
        //    return result;
        //}

        //static string Test(string test, string name)
        //{
        //    return RunMethod(test(name));
        //}

        //static string HelloWorld(string name)
        //{
        //    return $"Hello {name}!";
        //}
    }
}
