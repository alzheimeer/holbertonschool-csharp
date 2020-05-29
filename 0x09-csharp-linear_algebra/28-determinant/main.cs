using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { 3, -2 }, { 7, 4 } };
        Console.WriteLine(MatrixMath.Determinant(matrix));
    }
}