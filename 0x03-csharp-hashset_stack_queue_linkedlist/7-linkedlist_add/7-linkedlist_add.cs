using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        myLList.AddFirst(n);

        return myLList.First;
    }
}