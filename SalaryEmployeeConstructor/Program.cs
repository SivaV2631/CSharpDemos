using System;

namespace SalaryEmployeeConstructor
{

    class Salary
    {
        public double Basic { get; private set; }
        public double TA { get; private set; }
        public double DA { get; private set; }
        public double HRA { get; private set; }

        public double GetBasic(double x)
        {   
            Basic = x;
            return Basic;
            
        }
        public double GetTA(double Basic)
        {
            TA = (Basic * 10) / 100; 
            return TA;

        }
        public double GetDA(double Basic)
        {
            DA = (Basic * 40)/100;
            return DA ;
        }

        public double GetHRA(double Basic)
        {   
            HRA = (Basic * 20) / 100; ;
            return HRA;           
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salary of Employee");
            Console.WriteLine();

            Salary salary = new Salary();

             Console.Write("Enter Basic Salary :");
            double  a = double.Parse(Console.ReadLine());
            Console.WriteLine();

            salary.GetBasic(a);
            salary.GetTA(salary.Basic);
            salary.GetDA(salary.Basic);
            salary.GetHRA(salary.Basic);


            double Total_Salary;
            Total_Salary = salary.Basic + salary.TA + salary.DA + salary.HRA;

            Console.WriteLine("Basic salary = " + salary.Basic);
            Console.WriteLine("Travelling Allowance(10 % of Basic Salary) = " + salary.TA);
            Console.Write("Dearness Allowance (40 % of Basic Salary) = " + salary.DA);
            Console.Write("\nHouse Rent Allowance (20 % of Basic Salary) = " + salary.HRA);
            Console.Write("\nTotal Salary  = " + Total_Salary);
        }
    }
}
