using System;

namespace NullableExample
{
    class Nullable
    {
        public static void Main(string[] args)
        {
            int? A = null;
            Console.WriteLine(A.GetValueOrDefault());  

            int? B = A ?? 3;  
            Console.WriteLine(B);
            Console.WriteLine(B.GetValueOrDefault());

            Console.WriteLine(A.HasValue);
            Console.WriteLine(B.HasValue);
           
        }
    }
}
