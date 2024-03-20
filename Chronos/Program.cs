using System;
using System Diagnostic;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1= new Stopwatch();
            Stopwatch crono2= new Stopwatch();

            crono1.start();
            Thread.Sleep(600);

            crono2.start();
            Thread.Sleep(200);

            crono1.Stop();
            crono2.Stop();

            double time1= crono1.Elapsed.TotalSeconds;
            double time2= crono2.Elapsed.TotalSeconds;

            Console.Writeline($"{time1:f3}");
            Console.Writeline($"{time2:f3}");
        }
    }
}
