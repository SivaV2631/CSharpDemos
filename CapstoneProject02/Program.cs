using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace CapstoneProject02
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|\tLIBRARY MANAGEMENT SYSTEM\t|");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("-----------------------------------------------------");

            bool flag = false;
            Console.Write("Enter User Name : ");
            string username = Console.ReadLine();
            Console.Write("Enter Password :");
            string password = Console.ReadLine();
            if (username == "siva" && password == "pass")
            {
                flag = true;

                int menu = -1;
                while (menu != 0)
                {
                    Console.WriteLine(" \tMAIN MENU");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("1. To Go Librarian Menu ");
                    Console.WriteLine("2. To GO Customer Menu");
                    Console.WriteLine("0  EXIT");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.Write("Enter your choice: ");
                    string menuInput = Console.ReadLine();
                    int.TryParse(menuInput, out menu);


                    switch (menu)
                    {
                        case 0:
                            Console.WriteLine("-----Thank You, Visit Again..------");
                            break;
                        case 1:
                            Librarian librarian = new Librarian();
                            librarian.LibrarianMenu();
                            break;
                        case 2:
                            Customer customer = new Customer();
                            customer.CustomerMenu();
                            break;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }


                }
            }
            else
            {
                Console.WriteLine("Invalid username or password");

            }

        }


    }
}

