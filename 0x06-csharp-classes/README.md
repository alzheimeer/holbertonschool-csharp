0x06. C# - Classes and Namespaces
=================================

Resources
---------

**Read or watch**:

*   [Object-Oriented Programming](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/object-oriented-programming "Object-Oriented Programming")
*   [Classes and Structs](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/ "Classes and Structs")
*   [Choosing Between Class and Struct](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct "Choosing Between Class and Struct")
*   [C# Classes & OOP](https://www.youtube.com/watch?reload=9&v=GAvhe6oe-_4&feature=youtu.be&t=4m57s "C# Classes & OOP") (_Start at 4:57_)
*   [Properties vs. Fields](https://www.jeremymorgan.com/blog/programming/properties-vs-fields/ "Properties vs. Fields")
*   [.toString() method](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring?redirectedfrom=MSDN&view=netframework-4.7.2 ".toString() method")
*   [How to Override the .ToString() method](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method "How to Override the .ToString() method")
*   [Classes](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes "Classes")
*   [Objects](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/objects "Objects")
*   [Constructors](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors "Constructors")
*   [Namespaces](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/namespaces/using-namespaces "Namespaces")
*   [Using Properties](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties "Using Properties")
*   [this keyword](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this "this keyword")
*   [.NET Stack and Heap](https://www.youtube.com/watch?v=clOUdVDDzIM ".NET Stack and Heap")
*   [Fundamentals of garbage collection](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/fundamentals "Fundamentals of garbage collection")

### General

*   How to document C# code with XML comments
*   What is object-oriented programming?
*   What is a namespace
- RTA: In C # Namespaces are made up of a set of related objects like classes, delegates, structures, interfaces
*   What is a class
- RTA: CLASSES are the symbolic representation of OBJECTS. CLASSES describe fields, properties, methods and events.
*   What are objects and instances
- RTA: Creating an OBJECT from a class is what is called INSTANCE.
     
*   What is the difference between a class and an object or instance
*   What is a field
*   What is a constructor
*   What is a property
*   How to use `get` and `set`
*   When to use a constructor and when to use a property
*   What is `this` and when to use it
*   What is a method
*   What are access modifiers
*   What is a static class
*   What is a static member
*   What is encapsulation
- RTA: ENCAPSULATION: Groups data and codes in a single class.
*   What is polymorphism
- RTA: Thanks to this property, different classes can be used interchangeably. Other concepts associated with polymorphism are OVERLOAD, OVERWRITING and HIDING.
*   What is inherytance
- RTA: Allows the creation of a new class from an existing one, from which everything is inherited and can be customized by adding or modifying inherited properties and methods. Classes created from existing classes are called DERIVED CLASSES.
*   What is abstraction
*   What does `toString` do and how to override it
*   What is the difference between a class and a struct
*   When to use a class and when to use a struct
*   What is garbage collection in C#

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
*   All your public classes and their members should have XML documentation tags
*   All your private classes and members should be documented but without XML documentation tags

More Info
---------

From this project forward, documenting your code is **required**!

*   Use [XML documentation comments](https://docs.microsoft.com/en-us/dotnet/csharp/codedoc "XML documentation comments")
*   [XML Documentation Best Practices](https://blog.rsuter.com/best-practices-for-writing-xml-documentation-phrases-in-c/ "XML Documentation Best Practices")
*   All public types / classes and their members should be documented with `<summary>` tags
*   Private members should be documented but _without_ XML comments
*   To enable XML documentation in your project, you must add this line to the `PropertyGroup` in your `.csproj` file:
    *   `<DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile>`
*   Compiling your project with `/doc` will create an XML file in the directory specified above. With the `.xml` in the same directory as the compiled assembly, VSCode will automatically read the XML file and use it to provide tooltips with your documentation. Keep this in mind as you write your comments; they should give the programmer clear, concise information about your methods’ purpose and usage.

* * *

Quiz questions
--------------

#### Question #0

What are namespaces used for?

- [X]  Organizing classes
    
- [X]  Controlling the scope of class and method names within large projects
    
- [ ]  For exporting comments in a hierarchical format
    

#### Question #1

What is a class?

- [ ]  An object
    
- [X]  A reference type
    
- [X]  A blueprint for a data type
    
- [ ]  A value type
    

#### Question #2

An instance of a class is an object.

- [X]  True
    
- [ ]  False
    

#### Question #3

A constructor uses `get` and `set`.

- [ ]  True
    
- [X]  False
    

#### Question #4

What is a field?

- [ ]  An empty class
    
- [X]  A variable declared in a class
    
- [ ]  An access modifier
    

#### Question #5

A `private` modifier allows access to a field from outside the class.

- [ ]  True
    
- [X]  False
    

#### Question #6

What does `.ToString()` return by default?

- [X]  The fully qualified name of the type of the object
    
- [ ]  A count of characters in the object’s string representation
    
- [ ]  A string representation of the object
    

#### Question #7

What is encapsulation?

- [ ]  The ability of an object to perform in a wide variety of ways
    
- [X]  When a group of related methods, properties, and other members are treated as a single object
    
- [ ]  Providing functionality while hiding background details in order to simplify and increase efficiency
    

#### Question #8

What is polymorphism?

- [X]  The ability of an object to perform in a wide variety of ways
    
- [ ]  When a group of related methods, properties, and other members are treated as a single object
    
- [ ]  Providing functionality while hiding background details in order to simplify and increase efficiency
    

#### Question #9

What is abstraction?

- [ ]  The ability of an object to perform in a wide variety of ways
    
- [ ]  When a group of related methods, properties, and other members are treated as a single object
    
- [X]  Providing functionality while hiding background details in order to simplify and increase efficiency
    

#### Question #10

In the following code, what is `Dog`?

    public class Dog
    {
        string name;
        public int age = 2;
    
        public Dog(string n, int num)
        {
            name = n;
            age = num;
        }
    }
    

- [ ]  A public field
    
- [X]  A public class
    
- [ ]  A private field
    

#### Question #11

In the following code, what is `public Dog(string n, int num)`?

    public class Dog
    {
        string name;
        public int age = 2;
    
        public Dog(string n, int num)
        {
            name = n;
            age = num;
        }
    }
    

- [ ]  A public field
    
- [ ]  A property
    
- [X]  A constructor
    

#### Question #12

In the following code, what is `string name`?

    public class Dog
    {
        string name;
        public int age = 2;
    
        public Dog(string n, int num)
        {
            name = n;
            age = num;
        }
    }
    

- [X]  A private field
    
- [ ]  A public field
    
- [ ]  A constructor
    

#### Question #13

What is the fully qualified name of class `Daisy`?

    namespace Plants
    {
        class Flowers
        {
            class Daisy
            {
            }
        }
    }
    

- [ ]  `Daisy`
    
- [ ]  `Flowers.Daisy`
    
- [X]  `Plants.Flowers.Daisy`
    

#### Question #14

What is the fully qualified name of class `Order`?

    namespace Kingdom
    {
        class Phylum
        {
            class Class
            {
                class Order
                {
                    class Family
                    {
                        class Genus
                        {
                            class Species
                            {
                            }
                        }
                    }
                }
            }
        }
    }
    

- [ ]  `Phylum.Class.Order`
    
- [X]  `Kingdom.Phylum.Class.Order`
    
- [ ]  \``Kingdom.Phylum.Class.Order/Family.Genus.Species`
    

#### Question #15

Private classes should not be included in XML documentation because it exposes the inner workings of your code that you may not want to be shared.

- [X]  True
    
- [ ]  False
    

#### Question #16

Which of the following statements describe a static class?

- [X]  Static classes cannot be instantiated.
    
- [ ]  Static classes can contain instance constructors.
    
- [X]  Static classes can be used as a container for sets of methods that only need to operate on input and do not need to get or set any properties of their own.
    

#### Question #17

Which of the following statements describe a static member?

- [ ]  Multiple copies of a static member can exist.
    
- [X]  Static members are always accessed by the class name, not by an instance name.
    
- [X]  Static members are callable on a class even when no instance of the class has been created.
    

#### Question #18

    static void Main()
    {
      Dog d;
        d = new Dog();
        d.name = "Poppy";
    }
    
    public class Dog
    {
        string name;
        public int age = 0;
    }
    

In this example, which of the following statements is true?

- [ ]  The variable `d` and the new instance of Dog occupy the same place in memory in the stack
    
- [X]  The variable `d` and the new instance of Dog have different addresses in memory
    

#### Question #19

    static void Main()
    {
      Dog d;
        d = new Dog("Poppy", 2);
        d = new Dog("Django", 4);
    }
    
    public class Dog
    {
        string name;
        public int age = 0;
    
        public Dog(string n, int num)
        {
            name = n;
            age = num;
        }
    }
    

In this example, which of the following statements is true?

- [ ]  `Console.WriteLine(d.name)` will print `Poppy`
    
- [X]  `Console.WriteLine(d.name)` will print `Django`
    
- [ ]  The `Dog` instance for `Poppy` is still accessible
    
- [X]  The `Dog` instance for `Django` is still accessible
    

#### Question #20

All memory management in C# must be initiated with code – it is not done automatically.

- [ ]  True
    
- [X]  False
    


#### Students who are done with "0. Braaainsss"

#### 0\. Braaainsss mandatory

Create a new namespace `Enemies`. Create an empty public class `Zombie` within `Enemies` that defines a zombie.
```
    carrie@ubuntu:~/0x06-csharp-classes/0-enemy$ cat 0-main.cs 
    using Enemies;
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Enemies.Zombie newObject = new Enemies.Zombie();
    
            Console.WriteLine("newObject is of type {0}", newObject.GetType());
            Console.WriteLine("String representation: {0}", newObject.ToString());
        }
    }
    carrie@ubuntu:~/0x06-csharp-classes/0-enemy$ 
```    
```
    carrie@ubuntu:~/0x06-csharp-classes/0-enemy$ ls
    0-enemy.cs  0-enemy.csproj  0-main.cs  bin  obj
    carrie@ubuntu:~/0x06-csharp-classes/0-enemy$ dotnet run
    newObject is of type Enemies.Zombie
    String representation: Enemies.Zombie
    carrie@ubuntu:~/0x06-csharp-classes/0-enemy$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x06-csharp-classes`
*   File: `0-enemy/, 0-enemy/0-enemy.csproj, 0-enemy/0-enemy.cs`



#### Students who are done with "1. Healthy competition"

#### 1\. Healthy competition mandatory

Based on `0-enemy`, write a public class `Zombie` that defines a zombie by:

*   public field `health`
*   `health` should be an int and have no value
*   public constructor: `public Zombie()`
    *   sets the value of `health` to `0`
```
    carrie@ubuntu:~/0x06-csharp-classes/1-enemy$ cat 1-main.cs 
    using Enemies;
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Enemies.Zombie newObject = new Enemies.Zombie();
    
            Console.WriteLine("newObject is of type {0} and has a total of {1} health", newObject.GetType(), newObject.health);
        }
    }
    carrie@ubuntu:~/0x06-csharp-classes/1-enemy$ 
```    
```
    carrie@ubuntu:~/0x06-csharp-classes/1-enemy$ ls
    1-enemy.cs  1-enemy.csproj  1-main.cs  bin  obj
    carrie@ubuntu:~/0x06-csharp-classes/1-enemy$ dotnet run
    newObject is of type Enemies.Zombie and has a total of 0 health
    carrie@ubuntu:~/0x06-csharp-classes/1-enemy$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x06-csharp-classes`
*   File: `1-enemy/, 1-enemy/1-enemy.csproj, 1-enemy/1-enemy.cs`



#### Students who are done with "2. Health validation"

#### 2\. Health validation mandatory

Based on `1-enemy`, write a public class `Zombie` that defines a zombie by:

*   public field `health`
*   `health` should be an int and have no value
*   public constructor: `public Zombie()`
    *   sets the value of `health` to `0`
*   a new public constructor: `public Zombie(int value)`
    *   `value` must be greater than or equal to 0
    *   if `value` is less than 0, throw an `ArgumentException` with the message `Health must be greater than or equal to 0`
```
    carrie@ubuntu:~/0x06-csharp-classes/2-enemy$ cat 2-main.cs 
    using Enemies;
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Enemies.Zombie newObject1;
            Enemies.Zombie newObject2;
    
            try
            {
                newObject1 = new Enemies.Zombie(10);
                Console.WriteLine("newObject1 is of type {0} and has a total of {1} health", newObject1.GetType(), newObject1.health);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
    
            try
            {
                newObject2 = new Enemies.Zombie(-10);
                Console.WriteLine("newObject2 is of type {0} and has a total of {1} health", newObject2.GetType(), newObject2.health);
    
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    carrie@ubuntu:~/0x06-csharp-classes/2-enemy$ 
```    
```
    carrie@ubuntu:~/0x06-csharp-classes/2-enemy$ ls
    2-enemy.cs  2-enemy.csproj  2-main.cs  bin  obj
    carrie@ubuntu:~/0x06-csharp-classes/2-enemy$ dotnet run
    newObject1 is of type Enemies.Zombie and has a total of 10 health
    Health must be greater than or equal to 0
    carrie@ubuntu:~/0x06-csharp-classes/2-enemy$ 
```   

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x06-csharp-classes`
*   File: `2-enemy/, 2-enemy/2-enemy.csproj, 2-enemy/2-enemy.cs`



#### Students who are done with "3. Zombie health"

#### 3\. Zombie health mandatory

Based on `2-enemy`, write a public class `Zombie` that defines a zombie by:

*   **private** field `health`
*   `health` should be an int and have no value
*   public constructor: `public Zombie()`
    *   sets the value of `health` to `0`
*   public constructor: `public Zombie(int value)`
    *   `value` must be greater than or equal to 0
*   public method `public int GetHealth()` that returns the value of health of the Zombie object
```
    carrie@ubuntu:~/0x06-csharp-classes/3-enemy$ cat 3-main.cs 
    using Enemies;
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Enemies.Zombie newObject1;
            Enemies.Zombie newObject2;
    
            try
            {
                newObject1 = new Enemies.Zombie(10);
                Console.WriteLine("newObject1 is of type {0} and has a total of {1} health", newObject1.GetType(), newObject1.GetHealth());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
    
            try
            {
                newObject2 = new Enemies.Zombie(98);
                Console.WriteLine("newObject2 is of type {0} and has a total of {1} health", newObject2.GetType(), newObject2.GetHealth());
    
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    carrie@ubuntu:~/0x06-csharp-classes/3-enemy$ 
```    
```
    carrie@ubuntu:~/0x06-csharp-classes/3-enemy$ ls
    3-enemy.cs  3-enemy.csproj  3-main.cs  bin  obj
    carrie@ubuntu:~/0x06-csharp-classes/3-enemy$ dotnet run
    newObject1 is of type Enemies.Zombie and has a total of 10 health
    newObject2 is of type Enemies.Zombie and has a total of 98 health
    carrie@ubuntu:~/0x06-csharp-classes/3-enemy$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x06-csharp-classes`
*   File: `3-enemy/, 3-enemy/3-enemy.csproj, 3-enemy/3-enemy.cs`



#### Students who are done with "4. Hello, my name is"

#### 4\. Hello, my name is mandatory

Based on `3-enemy`, write a public class `Zombie` that defines a zombie by:

*   private field `health`
*   `health` should be an int and have no value
*   public constructor: `public Zombie()`
    *   sets the value of `health` to `0`
*   public constructor: `public Zombie(int value)`
    *   `value` must be greater than or equal to 0
*   private field `name`
*   `name` should be a string and have a default value of `(No name)`
*   public property `Name`
    *   `get`: retrieve name
    *   `set`: set name
*   public method `public int GetHealth()` that returns the value of health of the Zombie object
```
    carrie@ubuntu:~/0x06-csharp-classes/4-enemy$ cat 4-main.cs 
    using Enemies;
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Enemies.Zombie newObject1;
            Enemies.Zombie newObject2;
    
            try
            {
                newObject1 = new Enemies.Zombie(10);
                newObject1.Name = "Ed";
                Console.WriteLine("{0} is of type {1} and has a total of {2} health", newObject1.Name, newObject1.GetType(), newObject1.GetHealth());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
    
            try
            {
                newObject2 = new Enemies.Zombie(98);
                Console.WriteLine("{0} is of type {1} and has a total of {2} health", newObject2.Name, newObject2.GetType(), newObject2.GetHealth());
    
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    carrie@ubuntu:~/0x06-csharp-classes/4-enemy$ 
```    
```
    carrie@ubuntu:~/0x06-csharp-classes/4-enemy$ ls
    4-enemy.cs  4-enemy.csproj  4-main.cs  bin  obj
    carrie@ubuntu:~/0x06-csharp-classes/4-enemy$ dotnet run
    Ed is of type Enemies.Zombie and has a total of 10 health
    (No name) is of type Enemies.Zombie and has a total of 98 health
    carrie@ubuntu:~/0x06-csharp-classes/4-enemy$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x06-csharp-classes`
*   File: `4-enemy/, 4-enemy/4-enemy.csproj, 4-enemy/4-enemy.cs`



#### Students who are done with "5. Printing a zombie"

#### 5\. Printing a zombie mandatory

Based on `4-enemy`, write a public class `Zombie` that defines a zombie by:

*   private field `health`
*   `health` should be an int and have no value
*   public constructor: `public Zombie()`
    *   sets the value of `health` to `0`
*   public constructor: `public Zombie(int value)`
    *   `value` must be greater than or equal to 0
*   private field `name`
*   `name` should be a string and have a default value of `(No name)`
*   public property `Name`
    *   `get`: retrieve name
    *   `set`: set name
*   public method `public int GetHealth()` that returns the value of health of the Zombie object
*   public `.toString()` override that prints the Zombie object’s attributes to stdout
    *   Format: `Zombie name: <name> / Total Health: <health>` (see example below)
```
    carrie@ubuntu:~/0x06-csharp-classes/5-enemy$ cat 5-main.cs 
    using Enemies;
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Enemies.Zombie newObject1;
            Enemies.Zombie newObject2;
    
            try
            {
                newObject1 = new Enemies.Zombie(10);
                newObject1.Name = "Ed";
                Console.WriteLine(newObject1.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
    
            try
            {
                newObject2 = new Enemies.Zombie(98);
                Console.WriteLine(newObject2.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    carrie@ubuntu:~/0x06-csharp-classes/5-enemy$ 
```    
```
    carrie@ubuntu:~/0x06-csharp-classes/5-enemy$ ls
    5-enemy.cs  5-enemy.csproj  5-main.cs  bin  obj
    carrie@ubuntu:~/0x06-csharp-classes/5-enemy$ dotnet run
    Zombie Name: Ed / Total Health: 10
    Zombie Name: (No name) / Total Health: 98
    carrie@ubuntu:~/0x06-csharp-classes/5-enemy$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x06-csharp-classes`
*   File: `5-enemy/, 5-enemy/5-enemy.csproj, 5-enemy/5-enemy.cs`