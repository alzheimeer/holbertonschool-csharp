using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> newList;

        newList = List.CreatePrint(10);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(16);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(0);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(1);
        Console.WriteLine("List Length: " + newList.Count);        
    }
}