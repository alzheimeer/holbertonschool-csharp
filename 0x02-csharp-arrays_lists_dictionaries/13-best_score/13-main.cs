using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>();

        myDict.Add("John", 12);
        myDict.Add("Alex", 8);
        myDict.Add("Bob", 14);
        myDict.Add("Molly", 16);
        myDict.Add("Mary", 14);

        Console.WriteLine("Best Score: {0}", Dictionary.BestScore(myDict));
    }
}