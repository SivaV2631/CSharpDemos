using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinqDemo
{


   public class Student : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        #region System.IComparable members

        public int CompareTo(object obj)  
        {
            Student studentOther = obj as Student;          //Unboxing
            return this.Id.CompareTo(studentOther.Id);
        }

        #endregion

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            students.Add(new Student() { Id = 4, Name = "Fourth Student", Age = 18 });
            students.Add(new Student() { Id = 2, Name = "Second Student", Age = 35 });
            students.Add(new Student() { Id = 5, Name = "Fifth Student", Age = 29 });
            students.Add(new Student() { Id = 3, Name = "Third Student", Age = 42 });
            students.Add(new Student() { Id = 1, Name = "First Student", Age = 27 });

            Console.WriteLine("Before Sorting :");
            foreach(Student e in students)
            {
                Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();

            var query2 = from e in students            //LINQ 
                         orderby e.Id ascending
                         select e;
            Console.WriteLine("List of the employees in the collection - After  Sorting using LINQ");
            foreach (Student e in query2)              //GetEmumerator() is called here!
            {
                Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();
        }
    }
}
