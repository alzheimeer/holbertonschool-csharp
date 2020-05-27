using System;

///<summary>Class matrixmath</summary>
class MatrixMath
{
	///<summary>scalar * matrix</summary>
	///<return>matrix or matrix containing -1</return>
	public static double[,] MultiplyScalar(double[,] matrix, double scalar)
	{
		if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
		{
			double[,] matrix3 = {
				{0, 0},
				{0, 0}
			};
			matrix3[0, 0] = matrix[0, 0] * scalar;
			matrix3[0, 1] = matrix[0, 1] * scalar;
			matrix3[1, 0] = matrix[1, 0] * scalar;
			matrix3[1, 1] = matrix[1, 1] * scalar;
			return matrix3;
		}
		else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
		{
			double[,] matrix3 = {
				{0, 0, 0},
				{0, 0, 0},
				{0, 0, 0}
			};
			matrix3[0, 0] = matrix[0, 0] * scalar;
			matrix3[0, 1] = matrix[0, 1] * scalar;
			matrix3[0, 2] = matrix[0, 2] * scalar;
			matrix3[1, 0] = matrix[1, 0] * scalar;
			matrix3[1, 1] = matrix[1, 1] * scalar;
			matrix3[1, 2] = matrix[1, 2] * scalar;
			matrix3[2, 0] = matrix[2, 0] * scalar;
			matrix3[2, 1] = matrix[2, 1] * scalar;
			matrix3[2, 2] = matrix[2, 2] * scalar;
			return matrix3;
		}
		return new double[,] { { -1 } };
	}
}
