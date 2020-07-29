using System;

/// <summary>
/// Create a public class
/// </summary>
class Player
{
    /// <summary>
    /// propertys not be able to change or access
    /// </summary>
    protected string name;
    protected float maxHp;
    protected float hp;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="maxHp"></param>
    public Player(string name = "Player", float maxHp = 100f)
    {

        this.name = name;
        this.hp = maxHp;
        if (maxHp < 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
            this.maxHp = maxHp;
    }

    /// <summary>
    /// Method
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }

}

