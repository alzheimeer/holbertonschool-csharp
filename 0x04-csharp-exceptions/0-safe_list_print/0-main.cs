using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {1, 2, 3, 4, 5};
        int count;

        count = List.SafePrint(myList, myList.Count);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        count = List.SafePrint(myList, myList.Count - 2);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        count = List.SafePrint(myList, myList.Count + 2);
        Console.WriteLine("Number of integers printed: " + count);
    }
}