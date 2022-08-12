using System;

namespace ConvertToIntDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Decimal Number :");

            decimal no = Console.Read();                                                         
            no = Convert.ToInt32(no);       //method1
            Console.WriteLine("Int32 Value = {0} ",no);          //parameters

            Console.WriteLine();

            decimal no1 = Console.Read();       
            int value = decimal.ToInt32(no1);       //method2
            Console.WriteLine($"Int32 Value = {value} ");        //method String Interpolation($) for parameters

        }
    }
}
