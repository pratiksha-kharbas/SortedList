using System;
namespace LinkedList
{
    class Linkedlistdemo
    {
       static void Main(string[] args)
        {
            LinkedList<int> ts = new LinkedList<int>();
            ts.AddLast(1);
            ts.AddLast(2);
            ts.AddLast(3);
            ts.AddLast(4);
             ts.RemoveLast();
            if (ts.Count > 0)
            {
                Console.WriteLine("lINKED lIST IS NOT EMPTY");
            }

            
        }

    }
}