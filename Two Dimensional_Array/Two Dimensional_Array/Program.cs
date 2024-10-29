using System;
namespace array2DDemo
{
    class Demo
    {
        static void Main(String[] args)
        {
            //2d
            int[,] arr = new int[4, 5];
            arr = new int[4, 5] { 
            { 4,5,4,8,5} ,
            { 4,5,4,8,5},
            { 4,5,4,8,7 },
            { 4,5,4,8,9 } };

            Console.WriteLine("Printing the element of o th rows of 5th element  "+arr[0,4]);
            //accessing element through for loop
            for (int i = 0; i < 4; i++)//i is the row
            {
                
                    for (int j = 0; j < 5; j++)//j is the column
                    {
                        Console.Write(arr[i,j] + " " ); //only print on that line
                    }
                    Console.WriteLine();//new line
                
            }
        }

        

    }

}