using System;

namespace IUpperCaseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UPPERCASE using Interface!");
            Console.WriteLine();


            Demo obj = new Demo("siva kumar");
            Console.WriteLine(obj.str());

            Demo obj1 = new Demo("thank you");      
            Console.WriteLine(obj1.str());
        }
    }
    public interface IUpperCase
    {
        public abstract string Str();
        
    }
    public class Demo
    {
        public string Name { get; set; }

        public Demo(string N)
        {   
            Name = N;

        }
        public  string str()
        {
            string nam = Name;
            return nam.ToUpper();
        }
    }
}

