using System;

namespace InheritanceDemo
{
    internal class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Inheritance Demo!");
			
			Derived  objD = new Derived();             // creating object of derived class

			objD.input("Siva", "C#");                  // calling the method of base using the derived class object
		}
		class Base              // Base class
		{

			// data members
			public string name;
			public string subject;															
			public void input(string name, string subject)        // public method of base class
			{
				this.name = name;
				this.subject = subject;
				Console.WriteLine("Myself : " + name);
				Console.WriteLine("My Favorite Subject is: " + subject);
			}
		}

		// inheriting the Base 
		class Derived : Base
		{
			public Derived()                        // constructor of derived class
			{
				Console.WriteLine("Hello Everyone,");
			}
		}

	}

}

