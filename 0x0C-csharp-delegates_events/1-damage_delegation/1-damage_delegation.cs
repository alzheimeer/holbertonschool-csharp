using System;

/// <summary> Player Class which handles the Player attributes and actions </summary>
class Player
{
    string name;
    float maxHp;
    float hp;

    /// <summary> Player's Constructor </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0) this.maxHp = maxHp;
        else
        {
            this.maxHp = 100f;
            System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.hp = this.maxHp;
    }

    /// <summary> Prints the Player's current health </summary>
    public void PrintHealth()
    {
        System.Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }

    /// <summary> Delegate which handles the Health </summary>
    delegate void CalculateHealth(float damage);

    /// <summary> Handles Damage Health and apllies it to the hp </summary>
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
    }

    /// <summary> Handles Healing and applies it to the hp </summary>
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
    }
}