using System;

namespace MyMath
{
    ///<summary>method divide members matrix</summary>
    public class Matrix
    {
        /// <summary>divide</summary>
        /// <param name="matrix">Array of integers.</param>
        /// <param name="num">number to divide.</param>
        /// <returns>a new matrix containing divided elements.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if(num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return(null);
            }
            else if(matrix == null)
                return(null);
            else
            {
                for(int x = 0; x < matrix.GetLength(0); x++)
                    for(int y = 0; y < matrix.GetLength(1); y++)
                        matrix[x,y] = matrix[x,y] / num;
                return(matrix);
            }
        }
    }
}
