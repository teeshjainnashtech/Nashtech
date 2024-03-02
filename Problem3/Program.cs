
namespace Problem3;
using System;

    class Problem3
    {
        static void Main(string[] args)
        {
            
            StopWatch stopwatch = new StopWatch();
            stopwatch.Start();
            System.Threading.Thread.Sleep(2000); // Simulating some work
            TimeSpan duration1 = stopwatch.Stop();
            Console.WriteLine("Duration 1: " + duration1);

            stopwatch.Start();
            System.Threading.Thread.Sleep(1000); // Simulating some work
            TimeSpan duration2 = stopwatch.Stop();
            Console.WriteLine("Duration 2: " + duration2);
        }
    }


