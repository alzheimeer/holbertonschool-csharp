using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        LinkedListNode<int> current = myLList.First;
        
        while (current != null)
        {
            if (current.Value < n)
            {
                current = current.Next;
                if (current.Next == null)
                {
                    myLList.AddLast(n);
                    return myLList.First;
                }
            }
            else
            {
                myLList.AddBefore(current, n);
                return myLList.First;
            }
            
        }
        return newNode;
    }
}