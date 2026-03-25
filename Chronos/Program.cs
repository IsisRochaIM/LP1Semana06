using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(500);
            float c1 = crono1.ElapsedMilliseconds;
            Console.WriteLine($"crono1= {c1/1000:f4}");

            crono2.Start();
            Thread.Sleep(250);
            float c2 = crono2.ElapsedMilliseconds;
            Console.WriteLine($"crono2= {c2/1000:f4}");


        }
    }
}
