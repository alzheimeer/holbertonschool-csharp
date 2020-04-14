using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if(length > 0)
        {
            int i, j;
            for(i=0; i<length;i++)
            {
                for(j = 0; j<i;j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\\");
            }
        }
        Console.WriteLine(""); 
    }
}