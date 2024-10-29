using System;

// Implementing custom exceptions
public class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message) { }
}

public class NotEvenException : Exception
{
    public NotEvenException(string message) : base(message) { }
}

class Program
{
    static void CheckNumber(int number)
    {
        if (number < 0)
        {
            throw new NegativeNumberException("Number cannot be negative.");
        }
        else
        {
            Console.WriteLine("Number is valid.");
        }
    }

    static void checkeven(int number)
    {
        if (number % 2 != 0)
        {
            throw new NotEvenException("The number is not even.");
        }
        else
        {
            Console.WriteLine("Number is even.");
        }
    }

    static void Main(string[] args)
    {
        try
        {
           

            checkeven(5);  
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotEvenException ex)
        {
            Console.WriteLine(ex.Message);  
        }
    }
}
