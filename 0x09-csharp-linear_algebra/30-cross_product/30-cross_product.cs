using System;

///<summary>Class vectormath</summary>
class VectorMath
{
	///<summary>cross product of two vectors</summary>
	///<return>array or array with -1</return>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {   
        if (vector1.Length != 3 || vector2.Length != 3)
            return new double[] {-1};

        double[] rt = new double[3];
        rt[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
        rt[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
        rt[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
        return rt;
    }
}
