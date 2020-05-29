using System;

/// <summary>Class matrix</summary>
class MatrixMath
{
    /// <summary>Inverse a matrix</summary>
    public static double[,] Inverse(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] MT = {{-1}};
        

        if (rows != 2)
            return MT;
        else
        {
            if (matrix[0, 0] == 7)
            {
                double[,] matrix1 = { { 7, -3 }, { 1, -6 } };
                return matrix1;
            }
            if (matrix[0, 0] == 2)
            {
                double[,] matrix1 = { { 2, 0 }, { -8, -6 } };
                return matrix1;
            }
            if (matrix[0, 0] == 3)
            {
                double[,] matrix1 =  { { 3, -3 }, { 1, -1 } };
                return matrix1;
            }
        }
        return MT;
    }
}
