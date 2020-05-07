using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle aRect = new Rectangle();
        aRect.Width = 6;
        aRect.Height = 8;
        Console.WriteLine("aRect width: {0}", aRect.Width);
        Console.WriteLine("aRect height: {0}", aRect.Height);
        Console.WriteLine("aRect area: {0}", aRect.Area());
        Console.WriteLine(aRect.ToString());

        Console.WriteLine("------------------");

        Square aSquare = new Square();
        aSquare.Size = 12;
        Console.WriteLine("aSquare width: {0}", aSquare.Width);
        Console.WriteLine("aSquare height: {0}", aSquare.Height);
        Console.WriteLine("aSquare area: {0}", aSquare.Area());
        Console.WriteLine(aSquare.ToString());
    }
}