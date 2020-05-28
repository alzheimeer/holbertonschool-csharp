using System;

///<summary>Class MatrixMath</summary>
class MatrixMath
{
	///<summary>calculates the inverse of a 2D matrix</summary>
	///<return>matrix res or is not a 2D matrix or is non-invertible, return -1</return>
public static double[,] Inverse2D(double[,] matrix)
    {   
        int row = matrix.GetLength(0);
		int col = matrix.GetLength(1);
		double[,] rt = new double[col, row];
        if (row != 2)
            return new double[] {-1};

        
        return rt;
    }
}
