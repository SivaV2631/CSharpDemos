using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AnimalGenericDemo
{
    class Animal
    {   

        public void Name<T>(T data)
        {
            Console.WriteLine(data);
        }
        public void animalsound()
        {
            Console.WriteLine("Demo");
        }
    }
    class Dog : Animal
    {
        public void Name1<T>(T data)
        {
            Console.WriteLine("Animal Category =" + data);
        }
        public void character(int age, string name, string gender)
        {
            Console.WriteLine("Age :" + age +" "+ " name:" + name +" "+ " Gender:" + gender);
        }
        public  void animalSound()
        {
            Console.WriteLine("The Dog says: wow wow");
        }
    }
    class Frog : Animal
    {
        public void Name2<T>(T data)
        {
            Console.WriteLine("Animal Category =" + data);
        }
        public void character(int age, string name, string gender)
        {
            Console.WriteLine("Age :" + age + " " + " name:" + name + " " + " Gender:" + gender);
        }
        public void animalSound()
        {
            Console.WriteLine("The Frog says: crow crow");
        }
    }
    class Cat : Animal
    {
        public void Name3<T>(T data)
        {
            Console.WriteLine("Animal Category =" + data);
        }
        public void character(int age, string name, string gender)
        {

            Console.WriteLine("Age :" + age + " " + " name:" + name + " " + " Gender:" + gender);
        }
        public  void animalSound()
        {
            Console.WriteLine("The Frog says: meow meow");
        }
    }
    class Cow : Animal
    {
        public void Name4<T>(T data)
        {
            Console.WriteLine("Animal Category =" + data);
        }
        public void character(int age, string name, string gender)
        {

            Console.WriteLine("Age :" + age + " " + " name:" + name + " " + " Gender:" + gender);
        }
        public  void animalSound()
        {
            Console.WriteLine("The Cow says: Amma Amma");
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {

            Animal A = new Animal();
            A.Name<string>("Demo for Animal category using generic");
            A.Name<int>(100);
            Console.WriteLine();

            Dog myObj = new Dog();
            myObj.Name1<string>("DOG");
            myObj.animalSound();
            myObj.character(5, "dogname", "male");
            Console.WriteLine();

            Frog myObj2 = new Frog();
            myObj2.Name2<string>("FROG");
            myObj2.animalSound();
            myObj2.character(4, "frogname", "female");
            Console.WriteLine();


            Cat myObj3 = new Cat();
            myObj3.Name3<string>("CAT");
            myObj3.animalSound();
            myObj3.character(6, "catname", "male");
            Console.WriteLine();

            Cow myObj4 = new Cow();
            myObj4.Name4<string>("COW");
            myObj4.animalSound();
            myObj4.character(1, "cowname", "female");
            Console.WriteLine();

        }
    }
}