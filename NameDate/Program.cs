using System;

namespace NameDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name :");
            string name = Console.ReadLine();
            //Console.WriteLine(name);
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(name + "\t"  + dateTime.ToString("dd-MM-yyyy hh:mm:ss"));
        }
    }
}
