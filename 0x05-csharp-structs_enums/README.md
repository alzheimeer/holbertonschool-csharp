0x05. C# - Structs, Enumerations
================================

Resources
---------

**Read or watch**:

*   [Classes and Structs](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/ "Classes and Structs")
*   [Using Structs](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct "Using Structs")
*   [Enumeration types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum "Enumeration types")
*   [.toString() method](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring?redirectedfrom=MSDN&view=netframework-4.7.2 ".toString() method")
*   [How to Override the .ToString() method](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method "How to Override the .ToString() method")
*   [struct (C# Reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/struct "struct (C# Reference)")

### General

*   What is a struct
*   What is a constructor
*   What is a field
*   What is a property
*   What is an enumeration and when to use them
*   What does `toString` do and how to override it

Requirements
------------

### General

*   Allowed editors: `Visual Studio Code`
*   All files will be compiled on Ubuntu 14.04 LTS using `dotnet`
*   A `README.md` file, at the root of the folder of the project, is mandatory
*   All default C# files named `Program.cs` should be renamed to the name given in each task
*   Each C# task requires its own folder and `.csproj` file. Push all task folders to your Github and ensure the task names on the folders are correct
*   You do not need to push your `obj/` or `bin/` folders
*   In the following examples, the `main.cs` files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own `main.cs` files at compilation. Our `main.cs` files might be different from the one shown in the examples

* * *

Quiz questions
--------------

#### Question #0

What is a struct?

- [X] A value type
    
- [X] A blueprint for a data type
    
- [ ] A reference type
    

#### Question #1

Structs can be instantiated without a `new` operator, which makes allocation more efficient.

- [X] True
    
- [ ] False
    

#### Question #2

An instance of a struct is an object.

- [X] True
    
- [ ] False
    

#### Question #3

A struct can inherit from another struct.

- [ ] True
    
- [X] False
    

#### Question #4

Structs are stored on the:

- [X] Stack
    
- [ ] Heap
    

#### Question #5

In the following enumeration, what is the value of `West`?

    enum Directions { North, East, South, West };
    

- [ ] “West”
    
- [X] 3
    
- [ ] 4
    

#### Question #6

In the following code, what will print to the console?

    using System;
    
    struct Student 
    {
        public string name; 
        public int id;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Student betty;
    
            betty = new Student();
    
            Console.WriteLine(betty.id);
        }
    }
    

- [ ] `null`
    
- [X] 0
    
- [ ] Exception: Unassigned local variable
    

#### Question #7

In the following code, what will print to the console?

    using System;
    
    struct Employee
    {
        public string name;
        public int yearStarted;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee emily;
            Employee william;
    
            emily = new Employee("Emily", 2016);
    
            william = emily;
    
            william.name = "William";
    
            Console.WriteLine(emily.name);
        }
    }
    

- [X] “Emily”
    
- [ ] “William”
    
- [ ] `null`
    

#### Students who are done with "0. They're good dogs"

#### 0\. They're good dogs mandatory

Define a new enum `Rating` with the values `Good`, `Great`, `Excellent`.
```
    carrie@ubuntu:~/0x05-csharp-structs_enums\0-dog$ cat 0-main.cs
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Rating rating;
    
            rating = Rating.Great;
    
            Console.WriteLine("Score: " + rating);
            Console.WriteLine("Score: " + (int)rating);
        }
    }
    carrie@ubuntu:~/0x05-csharp-structs_enums\0-dog$
```    
```
    carrie@ubuntu:~/0x05-csharp-structs_enums\0-dog$ ls
    bin    obj    0-dog.cs    0-dog.csproj    0-main.cs
    carrie@ubuntu:~/0x05-csharp-structs_enums\0-dog$ dotnet run
    Score: Great
    Score: 1
    carrie@ubuntu:~/0x05-csharp-structs_enums\0-dog$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x05-csharp-structs_enums`
*   File: `0-dog/, 0-dog/0-dog.csproj, 0-dog/0-dog.cs`



#### Students who are done with "1. Chief Puppy Officer"

#### 1\. Chief Puppy Officer mandatory

Based on `0-dog`, define a new struct `Dog` with the following members:

*   `name`, type: `public string`
*   `age`, type: `public float`
*   `owner`, type: `public string`
*   `rating`, type `public Rating`
```
    carrie@ubuntu:~/0x05-csharp-structs_enums\1-dog$ cat 1-main.cs
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Dog poppy;
    
            poppy.name = "Poppy";
            poppy.age = 0.7f;
            poppy.owner = "Kris";
            poppy.rating = Rating.Excellent;
    
            Console.WriteLine("My name is {0} and I am {1}. I am an {2} dog. :)", poppy.name, poppy.age, poppy.rating);
        }
    }
    carrie@ubuntu:~/0x05-csharp-structs_enums\1-dog$
 ```   
```
    carrie@ubuntu:~/0x05-csharp-structs_enums\1-dog$ ls
    bin    obj    1-dog.cs    1-dog.csproj    1-main.cs
    carrie@ubuntu:~/0x05-csharp-structs_enums\1-dog$ dotnet run
    My name is Poppy and I am 0.7. I am an Excellent dog. :)
    carrie@ubuntu:~/0x05-csharp-structs_enums\1-dog$
 ```   

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x05-csharp-structs_enums`
*   File: `1-dog/, 1-dog/1-dog.csproj, 1-dog/1-dog.cs`



#### Students who are done with "2. A dog is the only thing on earth that loves you more than you love yourself"

#### 2\. A dog is the only thing on earth that loves you more than you love yourself mandatory

Based on `1-dog`, add a constructor to struct `Dog` that takes parameters.
```
    carrie@ubuntu:~/0x05-csharp-structs_enums\2-dog$ cat 2-main.cs
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Dog poppy;
    
            poppy = new Dog("Poppy", 0.7f, "Kris", Rating.Excellent);
    
            Console.WriteLine("My name is {0} and I am {1}. I am an {2} dog. :)", poppy.name, poppy.age, poppy.rating);
        }
    }
    carrie@ubuntu:~/0x05-csharp-structs_enums\2-dog$
```    
```
    carrie@ubuntu:~/0x05-csharp-structs_enums\2-dog$ ls
    bin    obj    2-dog.cs    2-dog.csproj    2-main.cs
    carrie@ubuntu:~/0x05-csharp-structs_enums\2-dog$ dotnet run
    My name is Poppy and I am 0.7. I am an Excellent dog. :)
    carrie@ubuntu:~/0x05-csharp-structs_enums\2-dog$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x05-csharp-structs_enums`
*   File: `2-dog/, 2-dog/2-dog.csproj, 2-dog/2-dog.cs`



#### Students who are done with "3. A dog will teach you unconditional love. If you can have that in your life, things won't be too bad"

#### 3\. A dog will teach you unconditional love. If you can have that in your life, things won't be too bad mandatory

Based on `2-dog`, override the `.ToString()` method to print the Dog object’s attributes to stdout.
```
Format:

    Dog Name: <name>
    Age: <age>
    Owner: <owner>
    Rating: <rating>
 ```   
```
    carrie@ubuntu:~/0x05-csharp-structs_enums\3-dog$ cat 3-main.cs
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Dog poppy;
    
            poppy = new Dog("Poppy", 0.7f, "Kris", Rating.Excellent);
    
            Console.WriteLine(poppy.ToString());
        }
    }
    carrie@ubuntu:~/0x05-csharp-structs_enums\3-dog$
```    
```
    carrie@ubuntu:~/0x05-csharp-structs_enums\3-dog$ ls
    bin    obj    3-dog.cs    3-dog.csproj    3-main.cs
    carrie@ubuntu:~/0x05-csharp-structs_enums\3-dog$ dotnet run
    Dog Name: Poppy
    Age: 0.7
    Owner: Kris
    Rating: Excellent
    carrie@ubuntu:~/0x05-csharp-structs_enums\3-dog$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x05-csharp-structs_enums`
*   File: `3-dog/, 3-dog/3-dog.csproj, 3-dog/3-dog.cs`