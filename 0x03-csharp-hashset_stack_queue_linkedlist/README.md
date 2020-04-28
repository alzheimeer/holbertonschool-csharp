0x03. C# - Data Structures: HashSet, Stack, Queue, LinkedList
=============================================================

Resources
---------

**Read or watch**:

*   [Collections](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections "Collections") (_Skip “Using LINQ to Access a Collection” and “Defining a Custom Collection”_)
*   [Intro to Stacks and Queues in C#](https://www.youtube.com/watch?v=DYQKPcADytc "Intro to Stacks and Queues in C#")
*   [Stacks and Queues in C#](https://www.youtube.com/watch?v=tW75yz3X_M4 "Stacks and Queues in C#")
*   [C# LinkedList](https://www.dotnetperls.com/linkedlist "C# LinkedList")
*   [foreach, in](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach-in "foreach, in")
*   [HashSet Class](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?redirectedfrom=MSDN&view=netframework-4.7.2 "HashSet Class")
*   [Stack Class](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?redirectedfrom=MSDN&view=netframework-4.7.2 "Stack Class")
*   [Queue Class](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?redirectedfrom=MSDN&view=netframework-4.7.2 "Queue Class")
*   [LinkedList Class](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?redirectedfrom=MSDN&view=netframework-4.7.2 "LinkedList Class")
*   [C# Language Reference](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/ "C# Language Reference")
*   [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions "C# Coding Conventions")

### General

*   How to create and use arrays
*   What are Collections in C#?
*   How to create and use hashsets
*   How to create and use stacks
*   How to create and use queues
*   How to create and use linked lists
*   How to use `foreach`

Requirements
------------

### C# Tasks

*   Allowed editors: `Visual Studio Code`
*   All files will be compiled on Ubuntu 14.04 LTS using `dotnet`
*   A `README.md` file, at the root of the folder of the project, is mandatory
*   All default C# files named `Program.cs` should be renamed to the name given in each task
*   You do not need to know about namespaces yet. Namespaces should be omitted in this project
*   Each C# task requires its own folder and `.csproj` file. Push all task folders to your Github and ensure the task names on the folders are correct
*   You do not need to push your `obj/` or `bin/` folders
*   In the following examples, the `main.cs` files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own `main.cs` files at compilation. Our `main.cs` files might be different from the one shown in the examples

* * *

Quiz questions
--------------

#### Question #0

What are the characteristics of a `HashSet`?

- [X]   A `HashSet` represents a collection of values
    
- [X]   A `HashSet` cannot contain duplicate elements
    
- [ ]   A `HashSet` is sorted
    
- [ ]   The number of values stored in a `HashSet` is fixed at its initialization
    

#### Question #1

A `Stack` is:

- [ ]   FIFO
    
- [X]   LIFO
    

#### Question #2

An example of a `Stack` is:

- [ ]   A line at a grocery store checkout
    
- [X]   Back / Forward buttons on web browsers
    

#### Question #3

A `Queue` is:

- [X]   FIFO
    
- [ ]   LIFO
    

#### Question #4

An example of a `Queue` is:

- [ ]   A number of plates placed one on top of the other
    
- [X]   A list of documents sent to a printer waiting to be printed
    

#### Question #5

Which operation puts data on top of a `Stack`?

- [X]   `.Push()`
    
- [ ]   `.Pop()`
    
- [ ]   `.Peek()`
    

#### Question #6

Which operation removes data from the top of a `Stack`?

- [ ]   `.Push()`
    
- [X]   `.Pop()`
    
- [ ]   `.Peek()`
    

#### Question #7

What operation gets a copy of the data from the top of the `Stack`?

- [ ]    `.Push()`
    
- [ ]    `.Pop()`
    
- [X]   `.Peek()`
    

#### Question #8

What operation puts new data at the end of a `Queue`?

- [ ]   `.Peek()`
    
- [X]   `.Enqueue()`
    
- [ ]    `.Dequeue()`
    

#### Question #9

What operation removes data from the beginning of the `Queue`?

- [ ]    `.Peek()`
    
- [ ]    `.Enqueue()`
    
- [X]    `.Dequeue()`
    

#### Question #10

What operation returns a copy of the data from the beginning of the `Queue`?

- [X]   `.Peek()`
    
- [ ]   `.Enqueue()`
    
- [ ]   `.Dequeue()`
    

#### Question #11

In C#, the `LinkedList<T>` class is:

- [ ]   A singly linked list
    
- [X]   A doubly linked list
    

#### Question #12

A `LinkedList` node can be accessed directly by its index

- [ ]   True
    
- [X]   False
    



#### Students who are done with "0. Unique addition"

#### 0\. Unique addition mandatory

Write a method that adds all unique integers in a list.

*   Class Name: List
*   Prototype: `public static int Sum(List<int> myList)`
*   Returns the sum of unique integers in given list
```
    alzheimeer@ubuntu:~/0x03/0-unique_add$ cat 0-main.cs 
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        // Main - entry point
        static void Main(string[] args)
        {
            List<int> myList1 = new List<int>() {1, 1, 2, 3, 4, 5, 6, 6, 7, 7, 8};
            List<int> myList2 = new List<int>() {98, 98, -14, 972, 0, -42, -972};
    
            Console.WriteLine(List.Sum(myList1));
            Console.WriteLine(List.Sum(myList2));
        }
    }
    alzheimeer@ubuntu:~/0x03/0-unique_add$ 
```
```    

    alzheimeer@ubuntu:~/0x03/0-unique_add$ ls
    0-main.cs  0-unique_add.cs  0-unique_add.csproj  bin  obj
    alzheimeer@ubuntu:~/0x03/0-unique_add$ dotnet run
    36
    42
    alzheimeer@ubuntu:~/0x03/0-unique_add$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x03-csharp-hashset_stack_queue_linkedlist`
*   File: `0-unique_add/, 0-unique_add/0-unique_add.csproj, 0-unique_add/0-unique_add.cs`



#### Students who are done with "1. Present in both"

#### 1\. Present in both mandatory

Write a method that returns a sorted list of common elements in two lists.

*   Class Name: `List`
*   Prototype: `public static List<int> CommonElements(List<int> list1, List<int> list2)`
*   Returns a new sorted list of common elements in two given lists
*   You cannot use `LINQ`
*   You cannot use `SortedList`
```
    alzheimeer@ubuntu:~/0x03/1-common_elements$ cat 1-main.cs 
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        // Main - entry point
        static void Main(string[] args)
        {
            List<int> myList1 = new List<int>() {1, 2, 3, 4, 5, 6};
            List<int> myList2 = new List<int>() {0, 2, 4, 6, 7, 8};
            List<int> newList = new List<int>();
    
            newList = List.CommonElements(myList1, myList2);
    
            foreach (int i in newList)
                Console.WriteLine(i);
        }
    }
    alzheimeer@ubuntu:~/0x03/1-common_elements$ 
```   
```
    alzheimeer@ubuntu:~/0x03/1-common_elements$ ls
    1-common_elements.cs  1-common_elements.csproj  1-main.cs  bin  obj
    alzheimeer@ubuntu:~/0x03/1-common_elements$ dotnet run
    2
    4
    6
    alzheimeer@ubuntu:~/0x03/1-common_elements$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x03-csharp-hashset_stack_queue_linkedlist`
*   File: `1-common_elements/, 1-common_elements/1-common_elements.csproj, 1-common_elements/1-common_elements.cs`



#### Students who are done with "2. Only differents"

#### 2\. Only differents mandatory

Write a method that returns a sorted list of all elements present in one or the other list but not both.

*   Class Name: `List`
*   Prototype: `public static List<int> DifferentElements(List<int> list1, List<int> list2)`
*   Returns a new sorted list of all elements present in one or the other list but not both of the given lists
*   You cannot use `LINQ`
*   You cannot use `SortedList`
```
    alzheimeer@ubuntu:~/0x03/2-different_elements$ cat 2-main.cs 
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        // Main - entry point
        static void Main(string[] args)
        {
            List<int> myList1 = new List<int>() {1, 2, 3, 4, 5, 6};
            List<int> myList2 = new List<int>() {0, 2, 4, 6, 7, 8};
            List<int> different;
    
            different = List.DifferentElements(myList1, myList2);
    
            foreach (int i in different)
                Console.WriteLine(i);
        }
    }
    alzheimeer@ubuntu:~/0x03/2-different_elements$ 
```    
```
    alzheimeer@ubuntu:~/0x03/2-different_elements$ ls
    2-different_elements.cs  2-different_elements.csproj  2-main.cs  bin  obj
    alzheimeer@ubuntu:~/0x03/2-different_elements$ dotnet run
    0
    1
    3
    5
    7
    8
    alzheimeer@ubuntu:~/0x03/2-different_elements$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x03-csharp-hashset_stack_queue_linkedlist`
*   File: `2-different_elements/, 2-different_elements/2-different_elements.csproj, 2-different_elements/2-different_elements.cs`



#### Students who are done with "3. Full stack"

#### 3\. Full stack mandatory

Given a `Stack<string>`, write a program that does the following:

*   Class: `MyStack`
*   Prototype: `public static Stack<string> Info(Stack<string> aStack, string newItem, string search)`
*   Print the number of items in `aStack`
    *   Format: `Number of items: <number>`
*   Print the item at the top of `aStack` without removing it
    *   Format: `Top item: <item>`
    *   If `aStack` is empty, print `Stack is empty`
*   Print if `aStack` contains a given item `search`
    *   Format: `Stack contains <search>: <True / False>`
*   If `aStack` contains the given item `search`, remove all items up to and including `search`; otherwise, leave `aStack` as is
    *   You can use `.Pop()` only once
*   Add a new given item `newItem` to `aStack`
*   Return `aStack`
```
    alzheimeer@ubuntu:~/0x03/3-stack_push_pop$ cat 3-main.cs
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        // Main - entry point
        static void Main(string[] args)
        {
            Stack<string> aStack = new Stack<string>();
    
            aStack.Push("C");
            aStack.Push("HTML");
            aStack.Push("Javascript");
            aStack.Push("Python");
            aStack.Push("React");
            aStack.Push("Ruby");
    
            foreach (string item in aStack)
                Console.WriteLine(item);
    
            Console.WriteLine("------");
    
            MyStack.Info(aStack, "C#", "Javascript");
    
            Console.WriteLine("------");
    
            foreach (string item in aStack)
                Console.WriteLine(item);
        }
    }
    alzheimeer@ubuntu:~/0x03/3-stack_push_pop$ 
```    
```
    alzheimeer@ubuntu:~/0x03/3-stack_push_pop$ ls
    3-main.cs  3-stack_push_pop.cs  3-stack_push_pop.csproj  bin  obj
    alzheimeer@ubuntu:~/0x03/3-stack_push_pop$ dotnet run
    Ruby
    React
    Python
    Javascript
    HTML
    C
    ------
    Number of items: 6
    Top item: Ruby
    Stack contains "Javascript": True
    ------
    C#
    HTML
    C
    alzheimeer@ubuntu:~/0x03/3-stack_push_pop$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x03-csharp-hashset_stack_queue_linkedlist`
*   File: `3-stack_push_pop/, 3-stack_push_pop/3-stack_push_pop.csproj, 3-stack_push_pop/3-stack_push_pop.cs`



#### Students who are done with "4. Queue it up"

#### 4\. Queue it up mandatory

Given a `Queue<string>`, write a program that does the following:

*   Class: `MyQueue`
*   Prototype: `public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)`
*   Print the number of items in `aQueue`
    *   Format: `Number of items: <number>`
*   Print the item at the top of `aQueue` without removing it
    *   Format: `First item: <item>`
    *   If `aQueue` is empty, print `Queue is empty`
*   Add a new given item `newItem` to `aQueue`
*   Print if `aQueue` contains a given item `search`
    *   Format: `Queue contains <search>: <True / False>`
*   If `aQueue` contains the given item `search`, remove all items up to and including `search`; otherwise, leave `aQueue` as is
    *   You can use `.Dequeue()` only once
*   Return `aQueue`
```
    alzheimeer@ubuntu:~/0x03/4-queue_enqueue_dequeue$ cat 4-main.cs
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        // Main - entry point
        static void Main(string[] args)
        {
            Queue<string> aQueue = new Queue<string>();
    
            aQueue.Enqueue("C");
            aQueue.Enqueue("HTML");
            aQueue.Enqueue("Javascript");
            aQueue.Enqueue("Python");
            aQueue.Enqueue("React");
            aQueue.Enqueue("Ruby");
    
            foreach (string item in aQueue)
                Console.WriteLine(item);
    
            Console.WriteLine("------");
    
            MyQueue.Info(aQueue, "C#", "Javascript");
    
            Console.WriteLine("------");
    
            foreach (string item in aQueue)
                Console.WriteLine(item);
        }
    }
    alzheimeer@ubuntu:~/0x03/4-queue_enqueue_dequeue$
```    
```
    alzheimeer@ubuntu:~/0x03/4-queue_enqueue_dequeue$ ls
    4-main.cs  4-queue_enqueue_dequeue.cs  4-queue_enqueue_dequeue.csproj  bin  obj
    alzheimeer@ubuntu:~/0x03/4-queue_enqueue_dequeue$ dotnet run
    C
    HTML
    Javascript
    Python
    React
    Ruby
    ------
    Number of items: 6
    First item: C
    Queue contains "Javascript": True
    ------
    Python
    React
    Ruby
    C#
    alzheimeer@ubuntu:~/0x03/4-queue_enqueue_dequeue$ 
    
```
**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x03-csharp-hashset_stack_queue_linkedlist`
*   File: `4-queue_enqueue_dequeue`


#### Students who are done with "5. Print a LinkedList"

#### 5\. Print a LinkedList mandatory

Write a method that creates and prints a LinkedList of integers of a given size.

*   Class Name: `LList`
*   Prototype: `public static LinkedList<int> CreatePrint(int size)`
*   Returns the newly created list
*   If `size` is negative, return an empty list
```
    alzheimeer@ubuntu:~/0x03/5-print_linkedlist$ cat 5-main.cs 
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        // Main - entry point
        static void Main(string[] args)
        {
            LinkedList<int> llist;
            int size;
    
            size = 8;
    
            llist = LList.CreatePrint(size);
            Console.WriteLine("-------------");
            Console.WriteLine("Linked List Length: " + llist.Count);
        }
    }
    alzheimeer@ubuntu:~/0x03/5-print_linkedlist$ 
```    
```
    alzheimeer@ubuntu:~/0x03/5-print_linkedlist$ ls
    5-main.cs  5-print_linkedlist.cs  5-print_linkedlist.csproj  bin  obj
    alzheimeer@ubuntu:~/0x03/5-print_linkedlist$ dotnet run
    0
    1
    2
    3
    4
    5
    6
    7
    -------------
    Linked List Length: 8
    alzheimeer@ubuntu:~/0x03/5-print_linkedlist$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x03-csharp-hashset_stack_queue_linkedlist`
*   File: `5-print_linkedlist/, 5-print_linkedlist/5-print_linkedlist.csproj, 5-print_linkedlist/5-print_linkedlist.cs`



#### Students who are done with "6. LinkedList length"

#### 6\. LinkedList length mandatory

Write a method that returns the number of elements in a LinkedList.

*   Class Name: `LList`
*   Prototype: `public static int Length(LinkedList<int> myLList)`
*   Returns the number of elements in a given LinkedList
*   You are not allowed to use `.Count()`
```
    alzheimeer@ubuntu:~/0x03/6-linkedlist_length$ cat 6-main.cs 
    using System;
    using System.Collections.Generic;
    class Program
    {
        // Main - entry point
        static void Main(string[] args)
        {
            LinkedList<int> myLList = new LinkedList<int>();
    
            myLList.AddLast(972);
            myLList.AddLast(0);
            myLList.AddLast(8);
            myLList.AddLast(98);
            myLList.AddLast(-4);
            myLList.AddLast(8);
    
            Console.WriteLine(LList.Length(myLList));
        }
    }
    alzheimeer@ubuntu:~/0x03/6-linkedlist_length$
```    
```
    alzheimeer@ubuntu:~/0x03/6-linkedlist_length$ ls
    6-linkedlist_length.cs  6-linkedlist_length.csproj  6-main.cs  bin  obj
    alzheimeer@ubuntu:~/0x03/6-linkedlist_length$ dotnet run
    6
    alzheimeer@ubuntu:~/0x03/6-linkedlist_length$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x03-csharp-hashset_stack_queue_linkedlist`
*   File: `6-linkedlist_length/, 6-linkedlist_length/6-linkedlist_length.csproj, 6-linkedlist_length/6-linkedlist_length.cs`


#### Students who are done with "7. Add node to the beginning"

#### 7\. Add node to the beginning mandatory

Write a method that adds a node to the beginning of a LinkedList.

*   Class Name: `LList`
*   Prototype: `public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)`
*   Returns the newly added node
```
    alzheimeer@ubuntu:~/0x03/7-linkedlist_add$ cat 7-main.cs 
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myLList = new LinkedList<int>();
    
            myLList.AddLast(1);
            myLList.AddLast(2);
            myLList.AddLast(3);
            myLList.AddLast(4);
            myLList.AddLast(5);
    
            foreach (int i in myLList)
                Console.Write(i + " ");
            Console.WriteLine();
    
            LList.Add(myLList, 0);
    
            foreach (int i in myLList)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
    alzheimeer@ubuntu:~/0x03/7-linkedlist_add$ 
```    
```
    alzheimeer@ubuntu:~/0x03/7-linkedlist_add$ ls
    7-linkedlist_add.cs  7-linkedlist_add.csproj  7-main.cs  bin  obj
    alzheimeer@ubuntu:~/0x03/7-linkedlist_add$ dotnet run
    1 2 3 4 5 
    0 1 2 3 4 5 
    alzheimeer@ubuntu:~/0x03/7-linkedlist_add$ 
 ```   

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x03-csharp-hashset_stack_queue_linkedlist`
*   File: `7-linkedlist_add/, 7-linkedlist_add/7-linkedlist_add.csproj, 7-linkedlist_add/7-linkedlist_add.cs`



#### Students who are done with "8. Find value"

#### 8\. Find value mandatory

Write a method that finds a value in a LinkedList and returns its index position in the list.

*   Class Name: `LList`
*   Prototype: `public static int FindNode(LinkedList<int> myLList, int value)`
*   Returns the index position of the first occurrence of the value given or `-1` if the value is not in the list
*   You are not allowed to use `.Find()` or `FindLast()`
```
    alzheimeer@ubuntu:~/0x03/8-linkedlist_find$ cat 8-main.cs 
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        // Main - entry point
        static void Main(string[] args)
        {
            LinkedList<int> myLList = new LinkedList<int>();
    
            myLList.AddLast(1);
            myLList.AddLast(4);
            myLList.AddLast(9);
            myLList.AddLast(16);
            myLList.AddLast(25);
            myLList.AddLast(36);
            myLList.AddLast(49);
    
            Console.WriteLine("Node Position: " + LList.FindNode(myLList, 16));
            Console.WriteLine("Node Position: " + LList.FindNode(myLList, 1));
            Console.WriteLine("Node Position: " + LList.FindNode(myLList, -10));
        }
    }
    alzheimeer@ubuntu:~/0x03/8-linkedlist_find$ 
```    
```
    alzheimeer@ubuntu:~/0x03/8-linkedlist_find$ ls
    8-linkedlist_find.cs  8-linkedlist_find.csproj  8-main.cs  bin  obj
    alzheimeer@ubuntu:~/0x03/8-linkedlist_find$ dotnet run
    Node Position: 3
    Node Position: 0
    Node Position: -1
    alzheimeer@ubuntu:~/0x03/8-linkedlist_find$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x03-csharp-hashset_stack_queue_linkedlist`
*   File: `8-linkedlist_find/, 8-linkedlist_find/8-linkedlist_find.csproj, 8-linkedlist_find/8-linkedlist_find.cs`



#### Students who are done with "9. Pop"

#### 9\. Pop mandatory

Write a method that deletes the head node of a LinkedList and returns that node’s data.

*   Class Name: `LList`
*   Prototype: `public static int Pop(LinkedList<int> myLList)`
*   Returns the value of the head node
*   If the list is empty, return `0`
```
    alzheimeer@ubuntu:~/0x03/9-linkedlist_pop$ cat 9-main.cs 
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        // Main - entry point
        static void Main(string[] args)
        {
            LinkedList<int> myLList = new LinkedList<int>();
    
            myLList.AddLast(11);
            myLList.AddLast(3);
            myLList.AddLast(-9);
            myLList.AddLast(47);
            myLList.AddLast(0);
            myLList.AddLast(-9);
    
            Console.WriteLine(LList.Pop(myLList));
        }
    }
    alzheimeer@ubuntu:~/0x03/9-linkedlist_pop$ 
```    
```
    alzheimeer@ubuntu:~/0x03/9-linkedlist_pop$ ls
    9-linkedlist_pop.cs  9-linkedlist_pop.csproj  9-main.cs  bin  obj
    alzheimeer@ubuntu:~/0x03/9-linkedlist_pop$ dotnet run
    11
    alzheimeer@ubuntu:~/0x03/9-linkedlist_pop$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x03-csharp-hashset_stack_queue_linkedlist`
*   File: `9-linkedlist_pop/, 9-linkedlist_pop/9-linkedlist_pop.csproj, 9-linkedlist_pop/9-linkedlist_pop.cs`



#### Students who are done with "10. Get node at index"

#### 10\. Get node at index mandatory

Write a method that returns the value of the nth node of a LinkedList.

*   Class Name: `LList`
*   Prototype: `public static int GetNode(LinkedList<int> myLList, int n)`
*   Returns the value of the node at the given index
*   If the node doesn’t exist, return `0`
*   Indexing starts at 0
```
    alzheimeer@ubuntu:~/0x03/10-linkedlist_get_node$ cat 10-main.cs 
    using System;
    using System.Collections.Generic;
    class Program
    {
        // Main - entry point
        static void Main(string[] args)
        {
            LinkedList<int> myLList = new LinkedList<int>();
    
            myLList.AddLast(91);
            myLList.AddLast(-22);
            myLList.AddLast(13);
            myLList.AddLast(14);
            myLList.AddLast(-54);
            myLList.AddLast(66);
            myLList.AddLast(37);
            myLList.AddLast(-8);
    
            Console.WriteLine(LList.GetNode(myLList, 5));
        }
    }
    alzheimeer@ubuntu:~/0x03/10-linkedlist_get_node$ 
```    
```
    alzheimeer@ubuntu:~/0x03/10-linkedlist_get_node$ ls
    10-linkedlist_get_node.cs  10-linkedlist_get_node.csproj  10-main.cs  bin  obj
    alzheimeer@ubuntu:~/0x03/10-linkedlist_get_node$ dotnet run
    66
    alzheimeer@ubuntu:~/0x03/10-linkedlist_get_node$ 
    
```
**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x03-csharp-hashset_stack_queue_linkedlist`
*   File: `10-linkedlist_get_node/, 10-linkedlist_get_node/10-linkedlist_get_node.csproj, 10-linkedlist_get_node/10-linkedlist_get_node.cs`


#### Students who are done with "11. LinkedList sum"

#### 11\. LinkedList sum mandatory

Write a method that returns the sum of all the data of a LinkedList.

*   Class Name: `LList`
*   Prototype: `public static int Sum(LinkedList<int> myLList)`
*   Returns the sum of the data in the LinkedList
```
    alzheimeer@ubuntu:~/0x03/11-linkedlist_sum$ cat 11-main.cs 
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        // Main - entry point
        static void Main(string[] args)
        {
            LinkedList<int> myLList = new LinkedList<int>();
    
            myLList.AddLast(21);
            myLList.AddLast(9);
            myLList.AddLast(-8);
            myLList.AddLast(54);
            myLList.AddLast(23);
            myLList.AddLast(-6);
            myLList.AddLast(5);
    
            Console.WriteLine(LList.Sum(myLList));
        }
    }
    alzheimeer@ubuntu:~/0x03/11-linkedlist_sum$ 
```    
```
    alzheimeer@ubuntu:~/0x03/11-linkedlist_sum$ ls
    11-linkedlist_sum.cs  11-linkedlist_sum.csproj  11-main.cs  bin  obj
    alzheimeer@ubuntu:~/0x03/11-linkedlist_sum$ dotnet run
    98
    alzheimeer@ubuntu:~/0x03/11-linkedlist_sum$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x03-csharp-hashset_stack_queue_linkedlist`
*   File: `11-linkedlist_sum/, 11-linkedlist_sum/11-linkedlist_sum.csproj, 11-linkedlist_sum/11-linkedlist_sum.cs`



#### Students who are done with "12. Insert at index"

#### 12\. Insert at index mandatory

Write a method that inserts a new node in the correct position in an ordered LinkedList.

*   Class Name: `LList`
*   Prototype: `public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)`
*   Returns the newly created node
```
    alzheimeer@ubuntu:~/0x03/12-linkedlist_insert$ cat 12-main.cs 
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        // Main - entry point
        static void Main(string[] args)
        {
            LinkedList<int> myLList = new LinkedList<int>();
            LinkedListNode<int> current;
    
            myLList.AddLast(1);
            myLList.AddLast(4);
            myLList.AddLast(9);
            myLList.AddLast(16);
            myLList.AddLast(25);
            myLList.AddLast(36);
            myLList.AddLast(49);
    
            current = myLList.First;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
    
            Console.WriteLine("------------------");
            LList.Insert(myLList, 21);
    
            current = myLList.First;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
    alzheimeer@ubuntu:~/0x03/12-linkedlist_insert$ 
```    
```
    alzheimeer@ubuntu:~/0x03/12-linkedlist_insert$ ls
    12-linkedlist_insert.cs  12-linkedlist_insert.csproj  12-main.cs  bin  obj
    alzheimeer@ubuntu:~/0x03/12-linkedlist_insert$ dotnet run
    1
    4
    9
    16
    25
    36
    49
    ------------------
    1
    4
    9
    16
    21
    25
    36
    49
    alzheimeer@ubuntu:~/0x03/12-linkedlist_insert$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x03-csharp-hashset_stack_queue_linkedlist`
*   File: `12-linkedlist_insert/, 12-linkedlist_insert/12-linkedlist_insert.csproj, 12-linkedlist_insert/12-linkedlist_insert.cs`


#### Students who are done with "13. Delete at index"

#### 13\. Delete at index mandatory

Write a method that deletes the node at given position in a LinkedList.

*   Class Name: `LList`
*   Prototype: `public static void Delete(LinkedList<int> myLList, int index)`
```
    alzheimeer@ubuntu:~/0x03/13-linkedlist_delete$ cat 13-main.cs 
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        // Main - entry point
        static void Main(string[] args)
        {
            LinkedList<int> myLList = new LinkedList<int>();
            LinkedListNode<int> current;
    
            myLList.AddLast(1);
            myLList.AddLast(4);
            myLList.AddLast(9);
            myLList.AddLast(16);
            myLList.AddLast(25);
            myLList.AddLast(36);
            myLList.AddLast(49);
    
            current = myLList.First;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
    
            Console.WriteLine("-------------------");
            LList.Delete(myLList, 5);
    
            current = myLList.First;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
    alzheimeer@ubuntu:~/0x03/13-linkedlist_delete$ 
```    
```
    alzheimeer@ubuntu:~/0x03/13-linkedlist_delete$ ls
    13-linkedlist_delete.cs  13-linkedlist_delete.csproj  13-main.cs  bin  obj
    alzheimeer@ubuntu:~/0x03/13-linkedlist_delete$ dotnet run
    1
    4
    9
    16
    25
    36
    49
    -------------------
    1
    4
    9
    16
    25
    49
    alzheimeer@ubuntu:~/0x03/13-linkedlist_delete$ 
 ```   

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x03-csharp-hashset_stack_queue_linkedlist`
*   File: `13-linkedlist_delete/, 13-linkedlist_delete/13-linkedlist_delete.csproj, 13-linkedlist_delete/13-linkedlist_delete.cs`
