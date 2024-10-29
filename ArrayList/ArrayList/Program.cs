using System;
using System.Collections;

namespace ArrayListExample

{ 
    class ArrayListDemo
    {
        public static void Main(string[] args)
        {
            ArrayList AR = new ArrayList(); 

          
            AR.Add(1);                
            AR.Add("Hello");          
            AR.Add(3.14);             
            AR.Add(true);             

            
            foreach (var item in AR)
            {
                Console.WriteLine(item);
            }
        }
    }
}
