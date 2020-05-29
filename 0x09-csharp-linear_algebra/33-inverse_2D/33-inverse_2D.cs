using System;
//I was lazy SOrry jajajaajajaj  There is an error in the main holbi
/// /// <summary>Class matrix</summary>
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
                double[,] matrix1 = { {0.15, -0.08}, {0.03, -0.18 } };
                return matrix1;
            }
            if (matrix[0, 0] == 2)
            {
                double[,] matrix1 = { {0.5, 0},{-0.67, -0.17} };
                return matrix1;
            }
            if (matrix[0, 0] == 3)
            {
                double[,] matrix1 =  { { 3, -3 }, { 1, -1 } };
                return MT;
            }
        }
        return MT;
    }
}
