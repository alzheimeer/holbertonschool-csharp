using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);

        if (aStack.Count <= 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: {0}", aStack.Peek());

        if (aStack.Contains(search))
        {
            Console.WriteLine("Stack contains \"{0}\": True", search);
            while (aStack.Contains(search))
                aStack.Pop();
        }
        else
            Console.WriteLine("Stack contains \"{0}\": False", search);

        
        aStack.Push(newItem);
        return (aStack);

    }
}