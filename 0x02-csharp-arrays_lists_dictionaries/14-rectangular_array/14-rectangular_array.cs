using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] mat = new int[5, 5];
                    
        for (int f = 0; f < 5; f++)
        {
            for (int c = 0; c < 5; c++)
                    mat[f, c] = 0;
        }
        mat[2,2] = 1;
        for (int f = 0; f < 5; f++)
        {
            for (int c = 0; c < 5; c++)
            {
                if (c < 4)
                    Console.Write(mat[f,c] + " ");
                else
                    Console.Write(mat[f,c]);
            }
            Console.WriteLine();
        }
           
    }
}

