using System;

namespace TrafficSignalDemo
{

    delegate void  TrafficDel();

    class TrafficSignal
    { 
        public static void Red()
        {
            Console.WriteLine("Red Light Signal-----------> " +  "To Stop");
        }

        public static void Yellow()
        {
            Console.WriteLine("Yellow Light Signal -----------> " + "To Get Ready");
        }

        public static void Green()
        {
            Console.WriteLine("Green Light Signal -----------> " + " To Go");
        }
        TrafficDel[] arr = new TrafficDel[3];
        public  void IdentifySignal()
        {
            arr[0] = new TrafficDel(Red);
            arr[1] = new TrafficDel(Yellow);
            arr[2] = new TrafficDel(Green);
        }
        public void Show()
        {
            arr[0]();
            arr[1]();
            arr[2]();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo for Traffic Signal Light!");
            Console.WriteLine();

            TrafficSignal ts = new TrafficSignal();
            ts.IdentifySignal();
            ts.Show();
        }
    }
}
