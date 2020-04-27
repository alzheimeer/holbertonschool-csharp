using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(1);
        myLList.AddLast(2);
        myLList.AddLast(3);
        myLList.AddLast(4);
        myLList.AddLast(5);

        foreach (int i in myLList)
            Console.Write(i + " ");
        Console.WriteLine();

        LList.Add(myLList, 0);

        foreach (int i in myLList)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}