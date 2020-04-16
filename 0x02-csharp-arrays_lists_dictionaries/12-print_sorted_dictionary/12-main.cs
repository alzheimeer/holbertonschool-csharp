using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();

        myDict.Add("language", "C");
        myDict.Add("track", "low level");
        myDict.Add("school", "Holberton");
        myDict.Add("address", "972 Mission St.");
        myDict.Add("city", "San Francisco");

        Dictionary.PrintSorted(myDict);
    }
}