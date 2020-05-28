using System;

/// <summary>Classmatrix</summary>
class MatrixMath
{
    /// <summary>shear a matrix</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] newMatrix = new double[2,2];
        double[,] shearMatrix = {
            {1, factor},
            {0, 1}
        };
        double[,] MT = {{-1}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return MT;
        if (direction != 'x' && direction != 'y')
            return MT;
        newMatrix[0,0] = shearMatrix[0,0] * matrix[0,0] + shearMatrix[0,1] * matrix[0,1];
        newMatrix[0,1] = matrix[0,1];
        newMatrix[1,0] = shearMatrix[0,0] * matrix[1,0] + shearMatrix[0,1] * matrix[1,1];
        newMatrix[1,1] = matrix[1,1];
        return newMatrix;
    }
}