using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Dog myDog = new Dog();
        object obj = myDog;
        Animal anotherAnimal = myDog;

        Console.WriteLine("myAnimal is a {0}", myAnimal.GetType());
        Console.WriteLine("myDog is a {0}", myDog.GetType());
        Console.WriteLine("obj is a {0}", obj.GetType());
        Console.WriteLine("anotherAnimal is a {0}", anotherAnimal.GetType());
    }
}