using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle aRect = new Rectangle();
        aRect.Width = 10;
        aRect.Height = 2;

        if (typeof(Rectangle).IsSubclassOf(typeof(Shape)))
            Console.WriteLine("Rectangle is a subclass of Shape");
        else
            Console.WriteLine("Rectangle is a NOT subclass of Shape");

        Console.WriteLine("Width: {0}", aRect.Width);
        Console.WriteLine("Height: {0}", aRect.Height);

        try
        {
            Console.WriteLine("Area: {0}", aRect.Area());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}