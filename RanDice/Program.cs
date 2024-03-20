using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int d= int.Parse(args[0]);
            int s= int.Parse(args[1]);

            int all= 0;
            Random w= new Random(s);

            for(int i = 0; i < n; i++)
            {
                all += w.Next(1, 7);
            }
        }
    }
}