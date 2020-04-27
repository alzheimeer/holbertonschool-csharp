
using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        var newList = new List<int>();
        var newList1 = new List<int>();
        foreach (int i in list1)
            foreach (int j in list2)
                if (i == j)
                    newList.Add(j);
        list1.AddRange(list2);
        list1.Sort();
        
        foreach(int x in list1)
            if (newList.Contains(x) == false)
                newList1.Add(x);

        return(newList1);
    }
}
