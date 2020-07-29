using System;
using System.Collections;
using System.Collections.Generic;


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

/// <summary> Class that inherits from Base class and IInterective </summary>
class Door : Base, IInteractive
{

    public Door(string name = "Door")
	{
		this.name = name;
	}

    /// <summary> Takes place when the object interacts with something </summary>
	public void Interact()
	{
        	Console.WriteLine("You try to open the {0}. It's locked.", name);
	}

  
}


/// <summary> Class that inherits from Base class and IInterective </summary>
class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability { get; set; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
	{
        if (durability < 0)
		{
			throw new Exception("Durability must be greater than 0");
		}
		this.name = name;
		this.durability = durability;
		this.isQuestItem = isQuestItem;
	}

    /// <summary> Takes place when the object interacts with something </summary>
	public void Interact()
	{
         if (durability <= 0)
		{
			Console.WriteLine("The {0} has been broken.", name);
		}
         else if (isQuestItem)
		{
			Console.WriteLine("You look at the {0}. There's a key inside.", name);
		}
        else
		{
			Console.WriteLine("You look at the {0}. Not much to see here.", name);
		}   	
	}

    /// <summary>check if the object has been broken</summary>
    public void Break()
	{
        durability--;

         if (durability > 0)
		{
			Console.WriteLine("You hit the {0}. It cracks.", name);
		}
         if (durability == 0)
		{
			Console.WriteLine("You smash the {0}. What a mess.", name);
		}
        if (durability < 0)
		{
			Console.WriteLine("The {0} is already broken.", name);
		}   	
	}
  
}

class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false)
	{
		this.name = name;
        this.isCollected = isCollected;
	}

    /// <summary> Takes place when the object interacts with something </summary>
	public void Collect()
	{
        if (isCollected == false)
        {
            isCollected = true;
        	Console.WriteLine("You pick up the {0}.", name);
        }
        else
        {
        	Console.WriteLine("You have already picked up the {0}.", name);
        }
	}
}


class Objs<T> : IEnumerable<T>
{
	List<T> lista = new List<T>();

   /// <summary> + an object to the list </summary>
    public void Add(T obj)
    {
        lista.Add(obj);
    }
	
    /// <summary> Returns list </summary>
    public IEnumerator<T> GetEnumerator()
    {
        return (lista.GetEnumerator());
    }
    /// <summary> private </summary>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return (GetEnumerator());
    }

}