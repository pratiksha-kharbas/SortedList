using System;
using System.Data.Common;

namespace classDemo
{
    class classobjectDemo
    {
        class Dog
        {
            string name = "tuffy";
            int age = 5;
            string color = "red";

            public int displayage()
            {
                return age;
            }

            public string displayname()
            {
                return name;
            }
        }

        class Cat
        {
            string name;
            int age;

            public void InfoOfCat(string name, int age)
            {
                this .name = name;  
                this .age = age;
                Console.WriteLine("The name cat is" + name);
                Console.WriteLine("The age of cat is "+age);

              
            }   


        }
        public static void  Main(String[] args)
        {
           Dog dog = new Dog();
            Cat cat = new Cat();
        
          Console.WriteLine("the age of dog"+ dog.displayage());
          Console.WriteLine("the name of dog"+dog.displayname());
        }
    }
}