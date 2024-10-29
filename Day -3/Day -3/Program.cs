using System;
using System.Diagnostics.CodeAnalysis;
class loopDemo
{
    public static void Main()
    {
        //for loop
        //printing the no from 1 to 20
        //If intiallization is not match with condition then it wil be false
        for (int i=0; i<=20;i++)
        {
            Console.WriteLine("The values are  "+i);
        }
        ////print even no
        for (int i = 0; i <= 20; i++)
        {
            if(i%2 ==0)
            {
                Console.WriteLine($"The {i} is Even no");
            }
            else
            {
                Console.WriteLine($"The {i} Odd no");
            }
        }
        //print  2 table
        for(int i=1; i<=10; i++)
        {
            Console.WriteLine("The table of 2  " + (i*2));
        }
        //print table of 3
        for(int i=1;i<=10; i++)
        {
            Console.WriteLine("The table of 3 " + (3 * i));
        }
        //Sum of even numbers
        int sum = 0;
        for (int i=0;i<=100;i++)
        {
            if (i% 2== 0)
            {
              
                sum = sum+ i;
                

            }
          
        }
        Console.WriteLine("The sum of even no " + sum);

        //print reverse number
        for(int i=100; i>=0 ;i--)
        {
            Console.WriteLine("The reverse the is i " +i);
        }

        //Fibonacchi series
        int n1=50 ; int n2 = 51; int n3;
        Console.WriteLine($"the value of {n1} & {n2}");
        for(int i = 0; i<=10;i++)
        {
            n3 = n1 + n2;
           Console.WriteLine(n3);
            n1 = n2;
            n2 = n3;
         
        }
        //calculate factorial

        int factrioal = 1;
        for(int i=1;i<=5;i++)
        {
            factrioal = factrioal*i;
           

        }
        Console.WriteLine("The factrioal of give no  " + factrioal);
    }

}



