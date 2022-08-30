using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReferenceDemo
{
    internal struct Student
    {
        public const string College = "SITAMS";

        // Attributes / Qualities of the data type "Student" (use nouns)
        public int StudentId;
        public string StudentName;
        public Department Department;

        // Behaviour of the data type "Student" (use verbs)
        public void Work()
        {
            Console.WriteLine("Student with ID = {0} is came college today", this.StudentId);
        }

        override public string ToString()
        {
            string output = "";
            output += $"  ID: {this.StudentId}";
            output += $"\n  Name: {this.StudentName}";
            output += $"\n  Department: {this.Department}";

            return output;
        }
    }
}
