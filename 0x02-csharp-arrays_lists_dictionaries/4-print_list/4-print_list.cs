using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        
        List<int> listA = new List<int>();

        if (size == 0)
	    {
	        Console.WriteLine();
	        return listA;
        }

        
        for(int i=0; i < size;i++) 
            {
                if(i != size-1)
                    Console.Write("{0} ",i);
                else
                    Console.Write(i);
                listA.Add(i); 
                
            }
        Console.WriteLine();
        return listA;

    }
}