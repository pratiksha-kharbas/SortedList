using System;

namespace Day_3
{
    
    public class Encapsulation
    {
        
        public class Rectangle
        {
            private int Length = 20;
            private int Breadth = 40;

          
            public int Display()
            {
                return Length * Breadth;
            }
        }

       
        internal class Square
        {
            private int Side = 4;

          
            public int Display()
            {
                return Side * Side;
            }
        }
    }

   
    public class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            
            Encapsulation.Rectangle rectangle = new Encapsulation.Rectangle();
            int rectangleArea = rectangle.Display();
            Console.WriteLine("Area of Rectangle: " + rectangleArea);

            Encapsulation.Square square = new Encapsulation.Square();
            int squareArea = square.Display();
            Console.WriteLine("Area of Square: " + squareArea);
        }
    }
}
