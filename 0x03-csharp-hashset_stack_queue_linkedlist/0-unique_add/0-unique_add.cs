using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        var newList = new List<int>();
        var sum = 0;

        foreach (var numero in myList)
        {
            if (!newList.Contains(numero))
                newList.Add(numero);
        }

        foreach (var numero in newList)
                sum += numero;
        return (sum);
    }
}