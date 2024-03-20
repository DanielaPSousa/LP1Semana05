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
        }
    }
}
