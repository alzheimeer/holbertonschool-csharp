using System;

///<summary>Base class</summary>
abstract class Base
{
  public string name;

  /// <summary> Function ToString override </summary>
   public override string ToString()
    {
        return (name + " is a " + GetType().ToString());
    }
}