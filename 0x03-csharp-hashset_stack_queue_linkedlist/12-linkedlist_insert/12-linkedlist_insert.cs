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
            {
                a = a.Next;
                if(a.Next == null)
                {
                    myLList.AddLast(n);
                    return myLList.First;
                }
            }
            else
            {
                myLList.AddBefore(a, n);
                return myLList.First;
            }
            
        }
        return newnode;
    }
}