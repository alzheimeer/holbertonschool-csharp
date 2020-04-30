using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();

        Console.WriteLine("newObject is of type {0} and has a total of {1} health", newObject.GetType(), newObject.health);
    }
}