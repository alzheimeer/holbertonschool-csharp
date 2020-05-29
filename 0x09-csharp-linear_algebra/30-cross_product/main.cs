using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = { 7, -2, 0 };
        double[] vector2 = { -4, 3, 6 };
        double[] result;

        result = VectorMath.CrossProduct(vector1, vector2);

        Console.WriteLine("(" + result[0] + ", " + result[1] + ", " + result[2] + ")");
    }
}