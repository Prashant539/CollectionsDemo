using System;
using System.Collections.Generic;
namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Collections");
            doListDemo();
            
        }
        private static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");

            foreach(var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
