using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReferenceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declaration & implicit instantiation
            Student stu1;

            // Initialization of the data members
            stu1.StudentId = 10;
            stu1.StudentName = "First Student";
            stu1.Department = Department.CSE;

            // Declaration, Explicit Instantiation, Initialization of data members
            Student stu2 = new Student()
                           {
                                 StudentId = 30,
                                 StudentName = "Second Student",
                                 Department = Department.ECE
                };

            Console.WriteLine(stu1.GetType());
            Console.WriteLine();

            Console.WriteLine("Student #1 properties:");
            Console.WriteLine("  ID: {0}", stu1.StudentId);
            Console.WriteLine("  Name: {0}", stu1.StudentName);
            Console.WriteLine("  Department: {0}", stu1.Department);

            Console.WriteLine();
            Console.WriteLine("Student #2 properties:");
            Console.WriteLine(stu2);        // same as: Console.WriteLine( emp2.ToString() );
            stu2.Work();

            

            Console.WriteLine();
            Console.WriteLine("All Students belong to: {0}", Student.College);
        }
    }
}