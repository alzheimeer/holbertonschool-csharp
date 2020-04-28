using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int f = 0;
        foreach(int i in myLList)
            f += i;
        return f;
    }
}
