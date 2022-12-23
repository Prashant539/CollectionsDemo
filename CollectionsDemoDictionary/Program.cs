using System;
namespace CollectionsDemoDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Collections");
            doDictionaryDemo();
        }
        public static void doDictionaryDemo()
        {
            Console.WriteLine("\nIn doDictionarytDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Ayush");
            dictionary.Add(102, "Vijay");
            Console.WriteLine("Access value using Key(Key = 100): " + dictionary[100]);
            Console.WriteLine("\nIterating Dictionary");
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key =" + element.Key + " &  value =" + element.Value);
            }

                
        }
    }
}
    

 

