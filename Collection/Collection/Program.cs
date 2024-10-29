//collection as the the name suggest it s collection of class
using System;
namespace ListDemo
{
    class listdemo
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Remove(0);
            Console.WriteLine(list[0]);
            for(int I=0; I<list.Count; I++)
            {
                Console.WriteLine(list[I]);
            }
            list.Remove(0);
            Console.WriteLine(list);
           
        }
    }
}