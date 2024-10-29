//While loop

int i = 1;
while (i<=10)
{
    Console.WriteLine(i);
    i++;
}
//even no using while loop
int j = 2;
while(j<=10)
{
    if(j%2==0)
    {
        Console.WriteLine("The value of even no" +j);
       
    }
    j++;
}
//print sum of even number using while loop

int k = 1;
int sum = 0;
while (k <= 10)
{
    if (k % 2 == 0) {
        sum = sum + k;
       
    }
    Console.WriteLine("The sum is", sum);
    k++;
}