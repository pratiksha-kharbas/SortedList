using System;
namespace SortedListDemo
{

    //Sorted list is the genric
    //sorted list is the collection keys and values 
    //sorted list keys should be unique
    class sortedlistdemo
    {
        static void Main(string[] args)
        {
            SortedList<int, string> a1 = new SortedList<int, string>();
            a1.Add(1, "Abc");
            a1.Add(2, "Abc");

            foreach (KeyValuePair<int, string> a in a1)
            {
                Console.WriteLine(a);
            }
        }
    }
}