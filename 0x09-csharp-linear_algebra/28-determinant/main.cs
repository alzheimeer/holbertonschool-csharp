using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { 1.2, -0.42 }, { 0.67, 2 } };

        Console.WriteLine(MatrixMath.Determinant(matrix));
    }
}