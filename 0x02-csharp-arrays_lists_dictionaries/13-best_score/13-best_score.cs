using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int v = 0;
        string c = "";

        if (myList.Count == 0)
			return "None";
        foreach(KeyValuePair<string, int> x in myList)
        {
            if (x.Value >= v)
            {
                v = x.Value;
                c = x.Key;
            }
        }
        return c;    
    }
}