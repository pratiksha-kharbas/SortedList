using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class DictionaryExample
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> book = new Dictionary<int, string>();
            book.Add(101, "abc");
            book.Add(102, "xyz");

            
            Console.WriteLine("Value for key 101: " + book[101]);

            
            Console.WriteLine("All Keys:");
            foreach (int key in book.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("All Values:");
            foreach (string value in book.Values)
            {
                Console.WriteLine(value);
            }

            
            Console.WriteLine("All Key-Value Pairs:");
            foreach (KeyValuePair<int, string> bookItem in book)
            {
                Console.WriteLine("Key: " + bookItem.Key + ", Value: " + bookItem.Value);
            }
        }
    }
}
