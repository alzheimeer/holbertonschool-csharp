using System;

abstract class Base
{

    public string name = "";
 

    public override string ToString()
    {
            return (name + " is a " + GetType().Name);
    }
}
