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
        if (maxHp <= 0f)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
            this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
    }

    /// <summary> Prints the player's health. </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }



    /// <summary> Handles Damage </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
        {
            System.Console.WriteLine("{0} takes 0 damage!", this.name);
            damage = 0f;
        }
        else
            System.Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        this.hp -= damage;
        ValidateHP(this.hp);
    }

    /// <summary> Handles Healing </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            System.Console.WriteLine("{0} heals 0 HP!", this.name);
            heal = 0f;
        }
        else
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        this.hp += heal;
        ValidateHP(this.hp);
    }

    /// <summary>Changes the Player's hp depending on damage or heal. </summary>
    /// <param name="newHp">The newHp of the Player.</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
            this.hp = 0f;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
    }

    /// <summary>Applies modifier to attack. </summary>
    /// <param name="baseValue">The normal attack power.</param>
    /// <param name="modifier">Modifies the attack power.</param>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue * 0.5f;
        else if (modifier == Modifier.Base)
            return baseValue;
        else
            return baseValue * 1.5f;
    }
}

/// <summary> Modifier</summary>
enum Modifier
{
    Weak,
    Base,
    Strong
}


/// <summary>Determines the strength of attack modifer. </summary>
/// <param name="baseValue">Normal attack.</param>
/// <param name="modifier">Modifier to apply to baseValue.</param>
delegate float CalculateModifier(float baseValue, Modifier modifier);


