using System;
using System.Collections;

namespace ArrayListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            
            arrList.Add(1);      //[0]              //Boxing
            arrList.Add(2);      //[1]     // arrList[0] == 10
            arrList.Add("Siva"); //[2]    
            arrList.Add(true);   //[3]


            for (int i = 0; i < arrList.Count; i++)
            {
                Console.WriteLine($" Value of {i} = {arrList[i]}");
            }
            Console.WriteLine();


            arrList.Add(new int[] { 100, 200, 300 });   //[4]
            Console.WriteLine(" 5th element :" + arrList[4]);
            int[] arr = arrList[4] as int[];
            int secondItem = arr[1];
            Console.WriteLine($"index[4]{"[1]"}: " + secondItem);
            //Console.WriteLine((arrList[4] as int[])[1]);
            Console.WriteLine("Length of ArrayList: {0}", arrList.Count);
            Console.WriteLine();    

            arrList.AddRange(new int[] { 1000, 2000, 3000 });
            Console.WriteLine("added 6th,7th,8th element using AddRange!");
            Console.WriteLine("Length of ArrayList: {0}", arrList.Count);

            Console.WriteLine();
            for (int i = 0; i < arrList.Count; i++) 
            {
                Console.WriteLine($" Value of {i} = {arrList[i]}");
            }

            
            
        }
    }
}