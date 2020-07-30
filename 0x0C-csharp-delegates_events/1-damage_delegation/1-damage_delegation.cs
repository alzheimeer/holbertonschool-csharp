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
    /// <summary>
    /// Delegate to change health.
    /// </summary>
    /// <param name="amt">The amount of health to be changed.</param>
    delegate void CalculateHealth(float amt);
    /// <summary>
    /// Prints the player's health.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }

    /// <summary>
    /// Player takes damage. Follows CalculateHealth delegate.
    /// </summary>
    /// <param name="damage">The amount of damage taken.</param>
    public void TakeDamage(float damage)
    {
        Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        if (damage < 0f)
            damage = 0f;
        this.hp -= damage;
    }

    /// <summary>
    /// Player heals HP. Follows CalculateHealth delegate.
    /// </summary>
    /// <param name="heal">The amount of HP player heals.</param>
    public void HealDamage(float heal)
    {
        Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        if (heal < 0f)
            heal = 0f;
        this.hp += heal;
    }
}