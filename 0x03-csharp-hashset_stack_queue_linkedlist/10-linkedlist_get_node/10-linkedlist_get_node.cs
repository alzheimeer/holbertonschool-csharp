using System;
using System.Collections.Generic;
class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int h = 0;
        if (myLList.Count < n )
            return 0;
        foreach(int i in myLList)
            {
                if (h == n)
                    return i;
                h += 1;
            }
        return 0;
    }
}
