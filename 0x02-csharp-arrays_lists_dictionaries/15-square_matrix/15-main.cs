using System;
class Program
{
    static void Main(string[] args)
    {
        int i, j;
        int[,] squareMatrix;
        int[,] myMatrix = new int[,]
        {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
        };

        squareMatrix = Matrix.Square(myMatrix);

        for (i = 0; i < squareMatrix.GetLength(0); i++)
        {
            for (j = 0; j < squareMatrix.GetLength(1); j++)
            {
                Console.Write(squareMatrix[i, j]);
                if (j != squareMatrix.GetLength(1) - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}