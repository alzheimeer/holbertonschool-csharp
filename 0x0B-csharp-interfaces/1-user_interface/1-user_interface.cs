using System;

///<summary>Base class</summary>
abstract class Base
{
  public string name = "";

	public override string ToString()
	{
		return (this.name + " is a " + this.GetType().ToString());
	}
}

/// <summary> Interactive interface </summary>
interface IInteractive
{
    void Interact();
}

/// <summary> Breakable Interface </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary> Collectable Interface </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();

}

/// <summary> Class that inherits from Base class and all interfaces </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	public int durability { get; set; }
	public bool isCollected { get; set; }

    /// <summary> Takes place when the object interacts with something </summary>
	public void Interact()
	{

	}

    /// <summary> Takes place when the object brakes. </summary>
	public void Break()
	{

	}

    /// <summary> Takes place when the object collects something.</summary>
	public void Collect()
	{

	}
}