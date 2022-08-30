using System;
using System.Collections;

namespace FibonacciIEnumerableDemo
{
    public class Demo : IEnumerable
    {
        private readonly int sequenceSize;

        public Demo(int sequenceSize)
        {
            this.sequenceSize = sequenceSize;
        }

        public IEnumerator GetEnumerator()  //method of Ienumerable
        {
            int n1 = 0;
            int n2 = 1;
            int count = 0;

            while (count <= sequenceSize)
            {
                var n1Temp = n1;
                n1 = n2;
                n2 = n1Temp + n2;
                ++count;

                yield return n2 - n1;
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            // Create a generator that will generate 10 Fibonacci numbers
            var generator = new Demo(10);
            Console.WriteLine("Fibonacci Series upto 10 is :");
            foreach (var num in generator)
            {
                Console.WriteLine(num);
            }
        }
    }
}