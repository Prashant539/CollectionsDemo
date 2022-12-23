using System;
namespace CollectionDemoStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Collections");
            doStackDemo();
        }
        public static void doStackDemo()
        {
            Console.WriteLine("\nIn doStackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Ravi");
            stack.Push("Amit");
            stack.Push("Garima");
            
            string pop = stack.Pop();
            foreach (var element in stack)
            {
                Console.WriteLine("elements");
            }
            Console.WriteLine("Pooped element: " + pop);
        }
    }
}
