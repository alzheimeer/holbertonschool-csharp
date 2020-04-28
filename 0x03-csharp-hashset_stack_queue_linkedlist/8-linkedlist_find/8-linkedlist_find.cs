using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        var z = 0;
        if(myLList.Contains(value))
        {
            foreach(int i in myLList)
            {
                if (i == value)
                    return(z);
                z += 1;
            }
        }
        else
        {
            return(-1);
        }
        return -1;
    }
}