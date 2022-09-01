using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait_TaskDemo
{
    internal class Program
    {
    
            static void Main(string[] args)
            {
                Console.WriteLine("--------------Async Await----------------");
                Console.WriteLine();
                Demo1();
                Demo2();
                Console.WriteLine("press any key to clear");
                Console.ReadKey();
                Console.Clear();
            }

            public static async Task Demo1()
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("one");
                        // Do something
                        Task.Delay(100).Wait();
                    }
                });
            }


        public static async void Demo2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("TWO");
                // Do something
                Task.Delay(100).Wait();
            }

        }

    }
}