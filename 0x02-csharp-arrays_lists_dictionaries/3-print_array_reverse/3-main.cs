using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] array2 = null;
        int[] array3 = {};
        int[] array4 = {98, -10, 0, 972, -42};

        Array.Reverse(array1);
        Array.Reverse(array2);
        Array.Reverse(array3);
        Array.Reverse(array4);
    }
}