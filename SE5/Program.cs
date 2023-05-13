using System;
using System.Threading;
using System.Diagnostics;
namespace SE5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Thread th1 = new Thread(work1);
            th1.Start();
            th1.Join();
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string s = string.Format("{0:00}:{0:00}:{0:00}", ts.Hours, ts.Minutes, ts.Seconds);
            Console.WriteLine(s);
        } 
            static void work1()
        {

            for(int i =1; i<= 10000; i++)
            {
                Console.WriteLine("work1::" + i);
            }
        }
    }
}
