using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>();
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        myDict.Add("John", 12);
        myDict.Add("Alex", 8);
        myDict.Add("Bob", 14);
        myDict.Add("Mary", 14);
        myDict.Add("Molly", 16);

        newDict = Dictionary.MultiplyBy2(myDict);

        foreach (KeyValuePair<string, int> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

        Console.WriteLine("--------------------");

        foreach (KeyValuePair<string, int> entry in newDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
    }
}