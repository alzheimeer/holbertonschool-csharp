using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[5, 5];
                    
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if(f == 2 && c == 2)
                        mat[f, c] = 1;
                    else
                        mat[f, c] = 0;
                }
            }

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
           
        }
    }
}
