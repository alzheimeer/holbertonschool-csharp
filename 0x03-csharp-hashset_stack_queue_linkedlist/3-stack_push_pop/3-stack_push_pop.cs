using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        string a = "";
        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count > 0)
            Console.WriteLine("Top item: {0}", aStack.Peek());
        else
            Console.WriteLine("Stack is empty");
        if (aStack.Contains(search))
        {
            a = "True";
            while (aStack.Contains(search))
                aStack.Pop();
        }
        else
            a = "False"; 
        Console.WriteLine("Stack contains {1}: {0}", a, search);
        aStack.Push(newItem);

        return (aStack);
    }
}