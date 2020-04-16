using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int s = 0;

        foreach(var a in myDict)
            s = s + 1;
        return s;
    }
}