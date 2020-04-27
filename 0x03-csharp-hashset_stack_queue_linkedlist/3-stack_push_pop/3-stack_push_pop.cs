using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
                int size = aStack.Count;
        Console.WriteLine("Number of items: {0}", size);
        if (size <= 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            string top = aStack.Peek();
            Console.WriteLine("Top item: {0}", top);
        }
        if (aStack.Contains(search))
        {
            Console.WriteLine("Stack contains \"{0}\": True", search);
            while (aStack.Contains(search))
            {
                aStack.Pop();
            }
        }                
        else
        {
            Console.WriteLine("Stack contains \"{0}\": False", search);
        }
        aStack.Push(newItem);
        return aStack;
    }
}