using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var a = 10;
        var b = new List<int>();

        if (Obj.IsOfTypeInt(a))
            Console.WriteLine("{0} is of type int", nameof(a));
        else
            Console.WriteLine("{0} is NOT of type int", nameof(a));

        if (Obj.IsOfTypeInt(b))
            Console.WriteLine("{0} is of type int", nameof(b));
        else
            Console.WriteLine("{0} is NOT of type int", nameof(b));
    }
}