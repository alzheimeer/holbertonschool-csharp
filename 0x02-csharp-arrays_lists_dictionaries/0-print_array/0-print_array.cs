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
        if (size == 0)
	    {
	        Console.WriteLine();
	        return index;
        }

        var array = new int[size];
        for(int i=0; i < size;i++) 
            array[i] =  i; 

        return array;
    }
}