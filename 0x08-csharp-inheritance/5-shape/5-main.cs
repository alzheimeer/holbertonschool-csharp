using System;

class Program
{
    static void Main(string[] args)
    {
        Shape aShape = new Shape();

        try
        {
            Console.WriteLine("Area: {0}", aShape.Area());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}