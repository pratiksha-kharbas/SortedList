using System;
namespace Methodemo
{
    class MethodPractice
    {
        void dispaly()
        {
            Console.WriteLine("Non-static method");

        }
        static int add(int a, int b)
        {
            int x = a;
            int y = b;

            return x + y;

        }

        public static void Main(string[] args)
        {
            MethodPractice methodPractice = new MethodPractice();
            methodPractice.dispaly();

            Console.WriteLine("calling static method" + MethodPractice.add);
        }
    }
}
