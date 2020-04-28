using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> act = myLList.First;
        while(act != null)
        {
            if(act.Value < n)
            {
                act = act.Next;
            }
            else
            {
                return(myLList.AddBefore(act, n));
                //break;
            }   
        }
        return(myLList.AddLast(n));  
    }
}