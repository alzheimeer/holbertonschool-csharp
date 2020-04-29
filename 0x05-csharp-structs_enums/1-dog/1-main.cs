using System;

class Program
{
    static void Main(string[] args)
    {
        Dog poppy;

        poppy.name = "Poppy";
        poppy.age = 0.7f;
        poppy.owner = "Kris";
        poppy.rating = Rating.Excellent;

        Console.WriteLine("My name is {0} and I am {1}. I am an {2} dog. :)", poppy.name, poppy.age, poppy.rating);
    }
}