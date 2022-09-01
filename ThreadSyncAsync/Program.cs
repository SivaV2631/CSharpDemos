using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace ThreadSyncAsync
{
    internal class Program
    {
        static void m()
        {
            Console.WriteLine("--- m() called on Thread: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("sleeps 5 secs");
            Console.WriteLine("awaken");
        }


        private static void sync()
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            Console.WriteLine("calling m() from Thread: {0}", Thread.CurrentThread.ManagedThreadId);
            Program.m();

            stopwatch.Stop();
            Console.WriteLine("Total Time taken: {0} milliseconds", stopwatch.ElapsedMilliseconds);
        }

        private static void async()
        {
           

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

           
            Console.WriteLine("calling m() from Thread: {0} Asynchronously", Thread.CurrentThread.ManagedThreadId);
            Thread t1 = new Thread(new ThreadStart(Program.m));
            t1.Start();

            // NOTE: Wait for each of the threads to complete their tasks and join back to Parent Thread
            t1.Join();
          

            stopwatch.Stop();
            Console.WriteLine("Total Time taken: {0} milliseconds", stopwatch.ElapsedMilliseconds);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=========== Methods are called Synchronously");
            sync();
            Console.WriteLine();

            Console.WriteLine("=========== Methods are called Aynchronously");
            async();
            Console.WriteLine();
        }

       


    }
}
