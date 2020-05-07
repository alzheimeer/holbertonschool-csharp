using System;
using System.Collections.Generic;

///<summary>class Shape</summary>
class Shape
{
    ///<summary>Throws an NotImplementedException</summary>
    public virtual int Area()
    {
       throw new NotImplementedException("Area() is not implemented");
    }
}