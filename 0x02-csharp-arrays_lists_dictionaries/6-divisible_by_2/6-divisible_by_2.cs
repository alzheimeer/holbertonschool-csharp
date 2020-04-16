using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> listA = new List<bool>();
        
        foreach (int i in myList)
        {
            if(i % 2 == 0)
                listA.Add(true);
            else
                listA.Add(false);
        }
        return listA;
    }
}