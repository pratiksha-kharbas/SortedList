//Stack which genric stack floow first in last out
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
namespace Stackdemo
{
    class program
    {
        //stack follow first in last out
        //stack is genreic
        //
        static void Main(String[] args)
        {
            Stack<int> s1 = new Stack<int>();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            s1.Push(4);
            Console.WriteLine(s1);
            s1.Pop();
    
            foreach (int i in s1)
            {
                Console.WriteLine(i);
            }
           
           
        }
    }
}
