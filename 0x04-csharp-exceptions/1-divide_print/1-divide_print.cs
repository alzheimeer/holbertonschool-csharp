using System;

class Int
{
    public static void divide(int a, int b)
    {
        int z = 0;
        try
        {
            z = (a/b);
        }
        catch
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, z);
        }
    }
}