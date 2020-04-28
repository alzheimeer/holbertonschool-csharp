using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);

        if (aQueue.Count <= 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: {0}", aQueue.Peek());

        if (aQueue.Contains(search))
        {
            Console.WriteLine("Stack contains \"{0}\": True", search);
            while (aQueue.Contains(search))
                aQueue.Dequeue();
        }
        else
            Console.WriteLine("Stack contains \"{0}\": False", search);

        
        aQueue.Enqueue(newItem);
        return (aQueue);
    }
}