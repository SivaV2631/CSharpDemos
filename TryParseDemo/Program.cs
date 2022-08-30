using System;

namespace TryParseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TryParse Function!");
            bool result;
            int a;
            string str = "10";
            result = int.TryParse(str, out a);
            Console.WriteLine($"String converted to numeric representation = {result} \n a = {a} \n type of a = {a.GetType()}" );
        }
    }
}
