using System;

namespace cs_con_Console
{
   
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Demo1");
            
            Console.WriteLine();

            Console.Write("Enter Name: ");
            ///
            String name = Console.ReadLine();
            
            Console.WriteLine("Hi " + name + " Welcome");

        }
    }
}
