using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {   
        //Create new node
        LinkedListNode<int> newnode = new LinkedListNode<int>(n);
        LinkedListNode<int> a = myLList.First;

        while(a != null)
        {
            if(a.Value < n)
                a = a.Next;
            else
                return (myLList.AddBefore(a, n));
            if(a.Next == null && a.Value < n)
                return (myLList.AddLast(n));
        }
        return newnode;
    }
}