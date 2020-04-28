using System;
using System.Collections.Generic;
class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(91);
        myLList.AddLast(-22);
        myLList.AddLast(13);
        myLList.AddLast(14);
        myLList.AddLast(-54);
        myLList.AddLast(66);
        myLList.AddLast(37);
        myLList.AddLast(-8);

        Console.WriteLine(LList.GetNode(myLList, 5));
    }
}