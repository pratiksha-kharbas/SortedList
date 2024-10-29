using System;
//ExceptionHandling 
namespace ExceptionHandlingPractice
{
    class Exceptionhandling
    {

        static void Main(string[] args)
        {
            int[] arr = { 5, 5, 6, 8 };
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[4]);
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Handle the exception" + e.Message);
            }
            //finally block always excute if exception occur or not
            finally
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }

        }
    }
}