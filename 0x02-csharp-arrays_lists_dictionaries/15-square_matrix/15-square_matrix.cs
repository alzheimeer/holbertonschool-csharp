using System;
class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int row = myMatrix.GetLength(0);
		int col = myMatrix.GetLength(1);
        int[,] nueva = new int[row, col];
        
        for (int f = 0; f < row; f++)
        {
            for (int c = 0; c < col; c++)
                    nueva[f, c] = Convert.ToInt16(Math.Pow(myMatrix[f, c], 2));
        }
        return nueva;

    }
}