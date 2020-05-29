using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { 2, 3 }, { -1, 0 } };
        double[,] result;

        result = MatrixMath.Transpose(matrix);

        Console.WriteLine("Original:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
                if (j != matrix.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Transposed:");
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