using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        SortedList<string, string> keys = new SortedList<string, string>(myDict);
		foreach (KeyValuePair<string, string> x in keys)
			Console.WriteLine("{0}: {1}", x.Key, x.Value);
    }
}