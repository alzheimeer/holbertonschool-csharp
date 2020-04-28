using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {   
        if (size < 0)
        {
            LinkedList<int> listEmpty = new LinkedList<int>();
            return listEmpty;
        }
        List<int> n = new List<int>();
        for (var i = 0; i < size; i++)
        {
            n.Add(i);
            Console.WriteLine(i);
        }
        LinkedList<int> s = new LinkedList<int>(n);
        return s;
        
    }
}