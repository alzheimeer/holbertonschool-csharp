using System;

///<summary>Class matrix</summary>
class MatrixMath
{
	///<summary>matrix determinant</summary>
	///<return>the result or -1</return>
	public static double Determinant(double[,] matrix)
	{
		if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
			return Math.Round(((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0])), 2);
		else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
		{
			double a = matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]));
			double b = matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]));
			double c = matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]));
			return Math.Round((a - b + c),2);
		}
		return - 1;
	}
}
