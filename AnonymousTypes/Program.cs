using System;

namespace AnonymousTypes
{
    internal class Program
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Details { get; set; }
        }

        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine();


            Student s = new Student() { Id =11,Name = "Ganesh", Details = "abc"  ,Age= 10};           //type declaration
            Console.WriteLine($"Id = {s.Id}, Name = {s.Name}, Age= {s.Age}, Details = {s.Details}, \nType = {s.GetType()} ");
            Console.WriteLine();

            Console.WriteLine("---------Anonymous types-------------");

            //Anonymous type
            var s1 = new {Id = 1,Name = "Siva",Age = 22, Details = "cse B.tech"};        //proprty signature  ->  (id,name,age,details)
            Console.WriteLine($"Id = {s1.Id}, Name = { s1.Name}, Age= { s1.Age}, Details = { s1.Details}, \nType = {s1.GetType()} ");
            Console.WriteLine();

            var s3 = new { Id = 2, Name = "kumar", Age = 20, Details = "cse B.tech" };      //same property signature --no new Anony type created
            Console.WriteLine($"Id = {s3.Id}, Name = {s3.Name}, Age= {s3.Age}, Details = {s3.Details}, \nType = {s3.GetType()} ");
            Console.WriteLine();


            var s2 = new {Name = "Gautham", RollNo = 3, Details = "mech B.tech", Age = 26};         //Changed Property signature and Id as RollNo --- new Anony type Created
            Console.WriteLine($"RollNo = {s2.RollNo}, Name = {s2.Name}, Age= {s2.Age}, Details = {s2.Details}, \nType = {s2.GetType()} ");
            Console.WriteLine();


        }
    }
}
