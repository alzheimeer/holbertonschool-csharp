using System;
using System.Collections.Generic;

class Obj
{
    ///<summary>True if the object is an instance Array, otherwise return False.</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return (typeof(Array).IsInstanceOfType(obj));
    }
}