using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();
        string key;
        string value;

        key = "school";
        value = "Holberton";

        Dictionary.AddKeyValue(myDict, key, value);

        foreach (KeyValuePair<string, string> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

        Console.WriteLine("------------------");

        key = "city";
        value = "San Francisco";

        Dictionary.AddKeyValue(myDict, key, value);

        foreach (KeyValuePair<string, string> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
    }
}