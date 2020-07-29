using System;

///<summary>abstract Base class</summary>
abstract class Base
{

    public string name = "";
 
    /// <summary>Function ToString override</summary>
    public override string ToString()
    {
            return (this.name + " is a " + this.GetType().Name);
    }
}
