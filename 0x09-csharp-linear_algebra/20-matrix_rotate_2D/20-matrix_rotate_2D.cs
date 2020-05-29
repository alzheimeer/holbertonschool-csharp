﻿using System;

///<summary>Class matrixmath</summary>
class MatrixMath
{
	///<summary>matrix rotation</summary>
	///<return>transformedPoint</return>
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{	
		if (matrix.GetLength(1) > 2)
			return new double[,] { { -1 } };
		double[,] rotationMatrix = {
			{Math.Cos(angle), -Math.Sin(angle)},
			{Math.Sin(angle), Math.Cos(angle)}
		};
		int row = matrix.GetLength(0);
		int col = matrix.GetLength(1);

		if (col == 2)
		{
			double[,] transformedPoint = new double[2, col];
			for (int i = 0; i < row; i++)
				for (int j = 0; j < 2; j++)
					for (int k = 0; k < col; k++)
						transformedPoint[i, j] += Math.Round(rotationMatrix[i, k] * matrix[k, j]);
			return transformedPoint;
		}
		return new double[,] { { -1 } };
	}
}
