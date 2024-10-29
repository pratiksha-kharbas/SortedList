using System;

namespace ArrayPractice
{
    class ArreyDemo
    {
        //first declare and intiallize
        static void Main(String [] args)
        {
            int[] intArray;
            intArray = new int[5];
            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 3;
            intArray[3] = 4;
            intArray[4] = 5;
            Console.WriteLine("Accesing the first element of an array " + intArray[0]);
            Console.WriteLine("The length of an array is"+ intArray.Length);

            //Accesing the elements using loop

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            foreach(int i in intArray)
            {
                Console.WriteLine("the value of i which accessing through foreach "+i);
            }
           
            int j =0;//intialization
            while(j<intArray.Length)//condition
            {
                Console.WriteLine("the value of i through while loop"+ intArray[j]);//acessing 0 th index of element
                j++;//increment/decrement
            }
            //do ..while
            int k = 0;
            do
            {
                Console.WriteLine("accessing the array element through do..while loop  " + intArray[k]);
                k++;
            }
            while (k < intArray.Length);

            String[] A = new string[] { "Sun", "Mon", "Tue", "Thur", "Fri", "Sat", "Sun"};
            Console.WriteLine("The string of a array" + A[1]);  
            //accessing all string string array elemnent
            foreach(String s in A)
            {
                Console.WriteLine(s);
            }
            

        }

}               
}
