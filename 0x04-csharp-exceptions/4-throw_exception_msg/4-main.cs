using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Except.ThrowMsg("C is fun");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}