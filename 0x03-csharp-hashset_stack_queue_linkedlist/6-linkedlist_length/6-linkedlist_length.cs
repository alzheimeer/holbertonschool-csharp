using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        var n = 0;
        foreach(int i in myLList)
            n += 1;

        return(n);
        
    }
}