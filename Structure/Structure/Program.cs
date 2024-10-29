using System;
namespace StructureDemo
{
    class StructureDemo
    {
        struct Person
        {
            public string Name;
            public int Id;
            public string Title;
            public string Address;
            public string City;
        }
        public static void Main(System.String[] args)
        {
            Person P1;
            P1.Name = "xyz";
            P1.City = "Shirur";
            
            Console.WriteLine(P1.Name + " " + P1.City);
        }
    }
}