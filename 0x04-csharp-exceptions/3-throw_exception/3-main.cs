using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Except.Throw();
        }
        catch (Exception)
        {
            Console.WriteLine("Exception raised");
        }
    }
}