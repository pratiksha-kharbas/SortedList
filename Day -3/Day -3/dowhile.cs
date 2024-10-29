using System;

namespace DoWhileLoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            do
            {
                Console.WriteLine("The value of i is: " + i);
                i++;
            }
            while (i < 5);
            Console.WriteLine(i);
        }
    }
}
