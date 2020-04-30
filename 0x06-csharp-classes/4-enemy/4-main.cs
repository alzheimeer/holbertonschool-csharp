using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            newObject1.Name = "Ed";
            Console.WriteLine("{0} is of type {1} and has a total of {2} health", newObject1.Name, newObject1.GetType(), newObject1.GetHealth());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(98);
            Console.WriteLine("{0} is of type {1} and has a total of {2} health", newObject2.Name, newObject2.GetType(), newObject2.GetHealth());

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}