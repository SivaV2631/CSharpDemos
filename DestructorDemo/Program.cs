using System;

namespace DestructorDemo
{

	class Destructor
	{
		int a, b;
		public Destructor()        // Defining the constructor
		{
			a = 0;
			b = 0;
		}
		public void SetValue(int c, int d)
		{
			a = c;
			b = d;
		}
		public void DisplayValue()
		{
			Console.WriteLine("value of a = " + a);
			Console.WriteLine("value of b = " + b);
		}
		~Destructor()
		{
			Console.WriteLine("Destructor was Called");
		}

	} 
	class Program
	{
		static void Main(string[] args)
		{

			Destructor D = new Destructor();

			D.SetValue(5,20);

			D.DisplayValue();

			

		} 

	} 

}
