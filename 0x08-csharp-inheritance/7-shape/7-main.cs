using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle aRect = new Rectangle();

        aRect.Width = 7;
        aRect.Height = 4;

        Console.WriteLine("Area: {0}", aRect.Area());
        Console.WriteLine(aRect.ToString());
    }
}