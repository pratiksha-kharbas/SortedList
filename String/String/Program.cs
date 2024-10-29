using System;
namespace Demo
{
    class sringDemo
    {
        public static void Main(string[] args)
        {
            //using class
            System.String Name = "Xyz";
            Console.WriteLine(Name);
            //using string keyword
            string id;
            id = "123";
            Console.WriteLine(id);
            //using string objet 
            String str = new string(id);
            Console.WriteLine(str);

            //Create array using string
            String[] a = new string[3];
            a = new string[] { "A", "B" , "c"};
            Console.WriteLine(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
           Console.WriteLine("Enter your name");
           String name  = Console.ReadLine();
            Console.WriteLine(name);
        }

    }
}
