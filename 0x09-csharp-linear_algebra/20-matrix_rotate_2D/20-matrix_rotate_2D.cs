using System;

///<summary>Class for matrix math</summary>
class MatrixMath
{
	///<summary>calcuating matrix rotation</summary>
	///<return>the result matrix or matrix containing -1</return>
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		double[,] rotation = {
			{Math.Cos(angle), -Math.Sin(angle)},
			{Math.Sin(angle), Math.Cos(angle)}
		};
		int m_row = matrix.GetLength(0);
		int m_col = matrix.GetLength(1);

		if (2 == m_row)
		{
			double[,] result = new double[2, m_col];
			for (int i = 0; i < m_row; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					for (int k = 0; k < m_col; k++)
					{
						result[i, j] += Math.Round(rotation[i, k] * matrix[k, j]);
					}
				}
			}
			return result;
		}
		return new double[,] { { -1 } };
	}
}
