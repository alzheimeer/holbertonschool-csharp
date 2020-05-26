using System;

///<summary>Class for VectorMath</summary>
class VectorMath
{
    ///<summary>method that adds two vectors and returns the resulting vector.</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
	if (vector1.Length == 2 && vector2.Length == 2)
	{
		double[] result = { 0, 0 };
		result[0] = vector1[0] + vector2[0];
		result[1] = vector1[1] + vector2[1];
		return result;
	}
	else if (vector1.Length == 3 && vector2.Length == 3)
	{
		double[] result = { 0, 0, 0 };
		result[0] = vector1[0] + vector2[0];
		result[1] = vector1[1] + vector2[1];
		result[2] = vector1[2] + vector2[2];
		return result;
	}
	return new double[] { -1 };
    }
}
