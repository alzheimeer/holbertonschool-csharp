using System;

///<summary>Class for VectorMath</summary>
class VectorMath
{
    ///<summary>method that multiplies a vector and a scalar and returns the resulting vector</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2)
        {
            double[] vector3 = { 0, 0 };
            vector3[0] = vector[0] * scalar;
            vector3[1] = vector[1] * scalar;
            return vector3;
        }
        else if (vector.Length == 3)
        {
            double[] vector3 = { 0, 0, 0 };
            vector3[0] = vector[0] * scalar;
            vector3[1] = vector[1] * scalar;
            vector3[2] = vector[2] * scalar;
            return (vector3);
        }
        else
            return new double[] { -1 };
    }
}
