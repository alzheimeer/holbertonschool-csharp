using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { 1, 2 }, { 3, 4 } };
        double[,] result;
        
        result = MatrixMath.Rotate2D(matrix, 2);

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j]);
                if (j != result.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}