using System;
using System.Collections.Generic;

namespace hashsetdemo
{
    // hashset is the coolection unique element which is genearic
    class hashsetparctice
    {
        public static void Main(string[] args)
        {
            HashSet<string> a1 = new HashSet<string>();
            a1.Add("Apple");
            a1.Add("Banana");
            a1.Add("Cherry");
            a1.Add("Apple");

            Console.WriteLine(a1);
            a1.Add("Pineapple");

            foreach (string s in a1)
            {
                Console.WriteLine(s);
            }
            
        }
    }
}