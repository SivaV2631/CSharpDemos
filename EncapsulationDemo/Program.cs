using System;

namespace EncapsulationDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Demo for Encapsulation!");

			Display obj = new Display();

			obj.NameAccessor = "Siva";
			obj.AgeAccessor = 22;

			Console.WriteLine("Name: " + obj.NameAccessor);
			Console.WriteLine("Age: " + obj.AgeAccessor);

			Display obj1 = new Display();

			obj.NameAccessor = "Gautham";
			obj.AgeAccessor = 26;

			Console.WriteLine("Name: " + obj1.NameAccessor);
			Console.WriteLine("Age: " + obj1.AgeAccessor);

		}
		public class Display
		{ 
			private String studentName;
			private int studentAge;
			public String NameAccessor
			{

				get
				{
					return studentName;
				}

				set
				{
					studentName = value;
				}

			}
			public int AgeAccessor
			{

				get
				{
					return studentAge;
				}

				set
				{
					studentAge = value;
				}
			}
		}



	}

}
