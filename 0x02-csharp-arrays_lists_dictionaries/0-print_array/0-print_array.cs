using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        
        var array = new int[size];

        if (size == 0)
	    {
	        Console.WriteLine();
	        return array;
        }

        
        for(int i=0; i < size;i++) 
            {
                Console.Write("{0}{1}",i , i != size-1 ? " ":"");
                array[i] =  i; 
            }
        Console.WriteLine();
        return array;
    }
}