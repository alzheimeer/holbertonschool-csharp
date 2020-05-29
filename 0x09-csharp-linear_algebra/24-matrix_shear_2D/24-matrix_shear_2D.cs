using System;

/// <summary>Classmatrix</summary>
class MatrixMath
{
    /// <summary>shear a matrix</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] newMatrix = new double[2,2];
        double[,] MT = {{-1}};
        double[,] shearMatrix;
        
        if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2)
            return MT;
        if (direction == 'x' || direction == 'y')
        {
            if (direction == 'x')
                shearMatrix = new double[,] {{1, 0}, {factor, 1}};
            else
                shearMatrix = new double[,] {{1, factor}, {0, 1}};
        }
        else
            return MT;
        for (int i = 0; i < 2; i++)
			for (int j = 0; j < 2; j++)
				for (int k = 0; k < 2; k++)
					newMatrix[i, j] += (matrix[i, k] * shearMatrix[k, j]);
		return newMatrix;
    }
}