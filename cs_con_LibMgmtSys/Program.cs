using System;

// Structural Patterns - Decorator Pattern Demo
// Creational Pattern - Late Instantiation Pattern

namespace cs_con_LibMgmtSys
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //Demo01();

            
            //Demo02();

             //Demo03();

            
            Demo04();
        }

        private static void Demo04()
        {
            Book2 bk1 = new Book2(0, "Experiments with Truth", 5);
            Book2 bk2 = new Book2(0, "Experiments with Truth", 2,
                new string[] { "Mahatma Gandhi" });
            Book2 bk3 = new Book2(0, "Experiments with Truth", 3,
                new string[] { "Mahatma Gandhi", "Mohandas Karamchand Gandhi" });

            Library objLib = new Library("My Public Library");
            objLib.Add(bk1);
            objLib.Add(bk2);
            objLib.Add(bk3);
            objLib.Add(new Newspaper(0, "Times of India", DateTime.Now));

            objLib.DisplayLibraryItems();

            Console.Write("Press any key to now borrow couple of books....");
            Console.ReadKey();
            Console.WriteLine();

            objLib.Borrow(2, "manoj");
            objLib.Borrow(2, "sharma");
            Console.WriteLine();

            Console.Write("Press any key to display all items in the library....");
            Console.ReadKey();
            Console.WriteLine();

            objLib.DisplayLibraryItems();

            Console.Write("Press any key to now return one of the books....");
            Console.ReadKey();
            Console.WriteLine();

            objLib.Return(2, "sharma");
            Console.WriteLine();

            Console.Write("Press any key to display all items in the library....");
            Console.ReadKey();
            Console.WriteLine();

            // objLib.DisplayLibraryItems();


            foreach (var item in objLib)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void Demo03()
        {
            Book2 bk1 = new Book2(1, "Book 1", 2);

            Borrowable item1 = new Borrowable(bk1);
            Console.WriteLine(item1);
            Console.WriteLine();

            item1.BorrowItem("user1");
            item1.BorrowItem("user2");

            Console.WriteLine(item1);
            Console.WriteLine();

            item1.ReturnItem("user1");

            Console.WriteLine(item1);
            Console.WriteLine();

        }

        private static void Demo02()
        {
            Book2 bk1 = new Book2(0, "Experiments with Truth", 5);
            Console.WriteLine(bk1);
            Console.WriteLine();

            Book2 bk2 = new Book2(0, "Experiments with Truth", 2,
                new string[] { "Mahatma Gandhi" });
            Console.WriteLine(bk2);
            Console.WriteLine();

            Book2 bk3 = new Book2(0, "Experiments with Truth", 3,
                new string[] { "Mahatma Gandhi", "Mohandas Karamchand Gandhi" });
            Console.WriteLine(bk3);
            Console.WriteLine();

        }

        private static void Demo01()
        {
            Book1 bk1 = new Book1(
                "Experiments with Truth", 5);
            Console.WriteLine(bk1);
            Console.WriteLine();

            Book1 bk2 = new Book1(
                "Experiments with Truth", 2,
                new string[] { "Mahatma Gandhi" });
            Console.WriteLine(bk2);
            Console.WriteLine();

            Book1 bk3 = new Book1(
                "Experiments with Truth", 3,
                new string[] { "Mahatma Gandhi", "Mohandas Karamchand Gandhi" });
            Console.WriteLine(bk3);
            Console.WriteLine();
        }
    }
}