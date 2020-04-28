using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {   
        //Create new node
        LinkedListNode<int> newnode = new LinkedListNode<int>(n);
        LinkedListNode<int> a;
        a = myLList.First;

        while(a != null)
        {
            if(a.Value < n)
                a = a.Next;
            else
            {
                myLList.AddBefore(a, n);
                return myLList.First;
            }
            if(a.Next == null && a.Value < n)
            {
                myLList.AddLast(n);
                return myLList.First;
            }
        }
        return newnode;
    }
}