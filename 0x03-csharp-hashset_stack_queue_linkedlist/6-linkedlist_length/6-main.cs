using System;
using System.Collections.Generic;
class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(972);
        myLList.AddLast(0);
        myLList.AddLast(8);
        myLList.AddLast(98);
        myLList.AddLast(-4);
        myLList.AddLast(8);

        Console.WriteLine(LList.Length(myLList));
    }
}