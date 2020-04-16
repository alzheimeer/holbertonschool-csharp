using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int eMax = 0;
        foreach (int i in myList)
        {
            if(i > eMax)
                eMax = i;

        }
        return eMax;
    }
}