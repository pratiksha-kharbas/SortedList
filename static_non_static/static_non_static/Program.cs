using System;
namespace program
{
    class staticprogram
    {
        public void display()
        {
            Console.WriteLine("Static  Method");
        }
        public static void Add(int x, int y)
        {
            int a = x;
            int b = y;
            Console.WriteLine("the addition is" +(a+b));
        }

    }
    class program

    {
        //calling method without parameter
         static int multiplication()
        {
            int a = 5020;
            int b = 5623;
            return a * b;
        }
        
        static void Main(System.String[] args)
        {
            staticprogram P1 = new staticprogram();
            P1.display();

            Console.WriteLine("calling static method directly classname");
            staticprogram.Add(1, 2);

           int result = multiplication();
            Console.WriteLine("the multiplication"+result);
        }
    }
}

