using System;
using System.Net.Security;
namespace EnumDemo
{
    //enum is a class which contain constant readonly variable
    //enum item bydefault value start from 0
    class EnumDemo
    {

        class program
        {
            enum Level
            {
                High,
                Low,
                medium
            }

            public static void Main(string[] args)
            {
                Level level = Level.High;
                Console.WriteLine(level);
                //to access enumitems wwe can used dot oprator
                //to access enumvalue we have to parse the item in int

                int high =(int) Level.High;
                Console.WriteLine(high);
                int low =(int) Level.Low;
                Console.WriteLine(low);
            }
        }
    }
}