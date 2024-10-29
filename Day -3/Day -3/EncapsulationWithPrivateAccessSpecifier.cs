using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__3
{
    internal class EncapsulationWithPrivateAccessSpecifier
    {
        class Rectangle
        {
            private double length = 20;
            private double width = 10;
            
            public double GetArea()
            {
                return length * width;
            }
        }
        class ExcuteRectangle
        { 
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle();
                r.GetArea();
                //Console.WriteLine("The length of rectangle" + r.length);

            }

        }

    }
}
