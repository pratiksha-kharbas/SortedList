using System;
namespace constantPratice
{
 
    class constant
    {

        const double val = 3.14 ;
        readonly int add = 45;
        public static void Main(String[] args)
        {
            //constant variable is like static so we called 
           constant con = new constant();
           Console.WriteLine(constant.val);
            //redaonly is like a non static so we called through object name
            Console.WriteLine(con.add);

           
        }
    }
}
