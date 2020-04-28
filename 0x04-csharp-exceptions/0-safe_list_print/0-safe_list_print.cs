using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int i = 0;
        for(; i < n; i++)
        {
            try
            {
                Console.WriteLine(myList[i]);
            }
            catch
            {
                return i;
            }
        }
        return i;


    }
}