using System;
using System.Collections;

namespace HashTableDemo
{
    class HashTableDemoClass
    {
        static void Main(string[] args)
        {
            Hashtable G = new Hashtable();
            G.Add(1, "Abc");
            G.Add(2, 4);

            // Printing only the keys
            Console.WriteLine("Keys:");
            foreach (int s in G.Keys)
            {
                Console.WriteLine(s);
            }

            // Printing both keys and values
            Console.WriteLine("\nKeys and Values:");
            foreach (DictionaryEntry A in G)
            {
                Console.WriteLine($"Key: {A.Key}, Value: {A.Value}");
            }
        }
    }
}
