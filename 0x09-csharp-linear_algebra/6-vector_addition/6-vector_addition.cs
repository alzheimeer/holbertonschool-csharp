using System;

///<summary>Class for VectorMath</summary>
class VectorMath
{
    ///<summary>method that adds two vectors and returns the resulting vector.</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length)
            return double[] vector3 = { -1 };
        if (vector1.Length == 2)
        {
            double[] vector3 = { 0, 0 };
            vector3[0] = vector1[0] + vector2[0];
            vector3[1] = vector1[1] + vector2[1];
            return vector3;
        }
        else if (vector1.Length == 3)
        {
            double[] vector3 = { 0, 0, 0 };
            vector3[0] = vector1[0] + vector2[0];
            vector3[1] = vector1[1] + vector2[1];
            vector3[2] = vector1[2] + vector2[2];
            return (vector3);
        }
        else
            return double[] { -1 };
    }
}