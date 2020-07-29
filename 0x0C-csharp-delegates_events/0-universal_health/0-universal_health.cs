using System;

/// <summary>Create a public class</summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary> Constructor </summary>
    /// <param name="name">The name of the player</param>
    /// <param name="maxHp">The player's maximum hit points</param>
    public Player(string name = "Player", float maxHp = 100f)
    {

        this.name = name;
        this.hp = this.maxHp;
        if (maxHp < 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
            this.maxHp = maxHp;
    }

    /// <summary>Method</summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }

}

