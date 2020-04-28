using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> current = myLList.First;
        int x = 0;
        while(current != null)
        {
            if(x == index)
                myLList.Remove(current);
            x += 1;
            current = current.Next;
        }
    }
}