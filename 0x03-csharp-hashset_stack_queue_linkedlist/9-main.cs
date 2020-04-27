using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(11);
        myLList.AddLast(3);
        myLList.AddLast(-9);
        myLList.AddLast(47);
        myLList.AddLast(0);
        myLList.AddLast(-9);

        Console.WriteLine(LList.Pop(myLList));
    }
}