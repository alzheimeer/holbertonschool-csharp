using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list1 = new List<int>() {1, 20, 16, 15, 54};
        List<int> list2 = new List<int>() {1, 0, 2, 3};
        List<int> result;

        result = List.Divide(list1, list2, 5);

        foreach (int i in result)
            Console.WriteLine(i);
    }
}