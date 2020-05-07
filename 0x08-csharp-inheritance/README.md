0x08. C# - Inheritance
======================

**Read or watch**:

*   [Inheritance in C#](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance "Inheritance in C#")
*   [Inheritance](https://www.youtube.com/watch?v=EiBCF7rYRtI "Inheritance")
*   [C# Inheritance](http://www.blackwasp.co.uk/inheritance.aspx "C# Inheritance") (_Read all 5 pages_)
*   [Type Checking: “TypeOf()”, “.GetType()”, or “is”?](https://stackoverflow.com/questions/983030/type-checking-typeof-gettype-or-is "Type Checking: "TypeOf()", ".GetType()", or "is"?")
*   [Knowing When to Use Override and New Keywords](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords "Knowing When to Use Override and New Keywords")

### General

*   What is inheritance
*   How is polymorphism achieved with inheritance
*   What is a base class
*   What is a derived class
*   How to create a derived class
*   How to override a method or property inherited from the base class
*   What is the difference between the `override` and `new` modifiers
*   What are `is`, `.GetType()`, `TypeOf()`, `.IsInstanceOfType()`, and `.IsSubclassOf()` and when to use them

Requirements
------------

### General

*   Allowed editors: `Visual Studio Code`
*   All files will be compiled on Ubuntu 14.04 LTS using `dotnet`
*   A `README.md` file, at the root of the folder of the project, is mandatory
*   All default C# files named `Program.cs` should be renamed to the name given in each task
*   Namespaces should be omitted in this project
*   Each C# task requires its own folder and `.csproj` file. Push all task folders to your Github and ensure the task names on the folders are correct
*   You do not need to push your `obj/` or `bin/` folders
*   In the following examples, the `main.cs` files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own `main.cs` files at compilation. Our `main.cs` files might be different from the one shown in the examples
*   All your public classes and their members should have XML documentation tags
*   All your private classes and members should be documented but without XML documentation tags

* * *

Quiz questions
--------------

#### Question #0

C# supports multiple inheritance.

- [ ] True
    
- [X] False
    

#### Question #1

All types in .NET inherit from `Object`.

- [X] True
    
- [ ] False
    

#### Question #2

Classes are reference types.

- [X] True
    
- [ ] False
    

#### Tips:

[Difference between a Value type and a Reference type](http://net-informations.com/faq/general/valuetype-referencetype.htm "Difference between a Value type and a Reference type")

#### Question #3

What does it mean to override a member?

- [X] To provide an alternate implementation of an inherited member
    
- [ ] To ignore an implementation of an inherited member
    
- [ ] To create a new method in an inherited class
    

#### Question #4

What keyword is used to allow a member to be overridden?

- [ ] sealed
    
- [ ] static
    
- [X] virtual
    

#### Question #5

What keyword requires that a class member be overridden?

- [ ] private
    
- [X] abstract
    
- [ ] override
    

#### Question #6

What modifier extends a base class method when overriding it?

- [X] override
    
- [ ] new
    
- [ ] virtual
    

#### Question #7

What modifier hides a base class method when overriding it?

- [ ] override
    
- [ ] virtual
    
- [X] new
    

#### Question #8

What operator is used in the syntax for creating a derived class?

- [ ] `>`
    
- [ ] `:`
    
- [ ] `>>`
    

#### Question #9

Which method prints the available properties of a class?

- [ ] `.GetType()`
    
- [ ] `.ShowProperties()`
    
- [X] `.GetProperties()`
    

#### Students who are done with "0. This is one of these"

#### 0\. This is one of these mandatory

Write a method that returns `True` if the object is an `int`, otherwise return `False`.

*   Class: `Obj`
*   Prototype: `public static bool IsOfTypeInt(object obj)`
```
    carrie@ubuntu:~/0x08-csharp-inheritance/0-is$ cat 0-main.cs
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = new List<int>();
    
            if (Obj.IsOfTypeInt(a))
                Console.WriteLine("{0} is of type int", nameof(a));
            else
                Console.WriteLine("{0} is NOT of type int", nameof(a));
    
            if (Obj.IsOfTypeInt(b))
                Console.WriteLine("{0} is of type int", nameof(b));
            else
                Console.WriteLine("{0} is NOT of type int", nameof(b));
        }
    }
    carrie@ubuntu:~/0x08-csharp-inheritance/0-is$
```    
```
    carrie@ubuntu:~/0x08-csharp-inheritance/0-is$ ls
    0-is.cs  0-is.csproj  0-main.cs  bin  obj
    carrie@ubuntu:~/0x08-csharp-inheritance/0-is$ dotnet run
    a is of type int
    b is NOT of type int
    carrie@ubuntu:~/0x08-csharp-inheritance/0-is$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x08-csharp-inheritance`
*   File: `0-is/, 0-is/0-is.csproj, 0-is/0-is.cs`


#### Students who are done with "1. For instance"

#### 1\. For instance mandatory

Write a method that returns `True` if the object is an instance of, or if the object is an instance of a class that inherited from, `Array`, otherwise return `False`.

*   Class: `Obj`
*   Prototype: `public static bool IsInstanceOfArray(object obj)`
```
    carrie@ubuntu:~/0x08-csharp-inheritance/1-instance$ cat 1-main.cs
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            var numArray = new int[10];
            var num = 10;
            var aList = new List<int>();
    
            if (Obj.IsInstanceOfArray(numArray))
                Console.WriteLine("{0} is an instance of type array or inherits from type array", nameof(numArray));
            else
                Console.WriteLine("{0} is NOT an instance of type array nor inherits from type array", nameof(numArray));
    
            if (Obj.IsInstanceOfArray(num))
                Console.WriteLine("{0} is an instance of type array or inherits from type array", nameof(num));
            else
                Console.WriteLine("{0} is NOT an instance of type array nor inherits from type array", nameof(num));
    
            if (Obj.IsInstanceOfArray(aList))
                Console.WriteLine("{0} is an instance of type array or inherits from type array", nameof(aList));
            else
                Console.WriteLine("{0} is NOT an instance of type array nor inherits from type array", nameof(aList));
        }
    }
    carrie@ubuntu:~/0x08-csharp-inheritance/1-instance$
```    
```
    carrie@ubuntu:~/0x08-csharp-inheritance/1-instance$ ls
    1-instance.cs  1-instance.csproj  1-main.cs  bin  obj
    carrie@ubuntu:~/0x08-csharp-inheritance/1-instance$ dotnet run
    numArray is an instance of type array or inherits from type array
    num is NOT an instance of type array or inherits from type array
    aList is NOT an instance of type array or inherits from type array
    carrie@ubuntu:~/0x08-csharp-inheritance/1-instance$
    
```
**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x08-csharp-inheritance`
*   File: `1-instance/, 1-instance/1-instance.csproj, 1-instance/1-instance.cs`



#### Students who are done with "2. Only subclass"

#### 2\. Only subclass mandatory

Write a method that returns `True` if the object is an instance of a class that inherits from the specified class, otherwise return `False`. The object must be a subclass; your method cannot return `True` if the object is an instance of the base class.

*   Class: `Obj`
*   Prototype: `public static bool IsOnlyASubclass(Type derivedType, Type baseType)`
```
    carrie@ubuntu:~/0x08-csharp-inheritance/2-subclass$ cat 2-main.cs
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            if (Obj.IsOnlyASubclass(typeof(Dog), typeof(Animal)))
                Console.WriteLine("Dog is a subclass of Animal");
            else
                Console.WriteLine("Dog is not a subclass of Animal");
    
            if (Obj.IsOnlyASubclass(typeof(Cat), typeof(Animal)))
                Console.WriteLine("Cat is a subclass of Animal");
            else
                Console.WriteLine("Cat is not a subclass of Animal");
    
            if (Obj.IsOnlyASubclass(typeof(Cat), typeof(Dog)))
                Console.WriteLine("Cat is a subclass of Dog");
            else
                Console.WriteLine("Cat is not a subclass of Dog");
    
            if (Obj.IsOnlyASubclass(typeof(Animal), typeof(Animal)))
                Console.WriteLine("Animal is a subclass of Animal");
            else
                Console.WriteLine("Animal is not a subclass of Animal");
        }
    }
    
    class Animal
    {
        // Empty class
    }
    
    class Dog : Animal
    {
        // Empty class
    }
    
    class Cat : Animal
    {
        // Empty class
    }
    carrie@ubuntu:~/0x08-csharp-inheritance/2-subclass$
```   
```
    carrie@ubuntu:~/0x08-csharp-inheritance/2-subclass$ ls
    2-subclass.cs  2-subclass.csproj  2-main.cs  bin  obj
    carrie@ubuntu:~/0x08-csharp-inheritance/2-subclass$ dotnet run
    Dog is a subclass of Animal
    Cat is a subclass of Animal
    Cat is not a subclass of Dog
    Animal is not a subclass of Animal
    carrie@ubuntu:~/0x08-csharp-inheritance/2-subclass$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x08-csharp-inheritance`
*   File: `2-subclass/, 2-subclass/2-subclass.csproj, 2-subclass/2-subclass.cs`



#### Students who are done with "3. Type"

#### 3\. Type mandatory

Write a method that prints the names of the available properties and methods of an object. See example for output format.

*   Class: `Obj`
*   Prototype: `public static void Print(object myObj)`

**References:**

*   [TypeInfo Class](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.typeinfo?redirectedfrom=MSDN&view=netframework-4.7.2 "TypeInfo Class")
*   [PropertyInfo Class](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo?redirectedfrom=MSDN&view=netframework-4.7.2 "PropertyInfo Class")
*   [MethodInfo Class](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.methodinfo?redirectedfrom=MSDN&view=netframework-4.7.2 "MethodInfo Class")
```
    carrie@ubuntu:~/0x08-csharp-inheritance/3-type_get$ cat 3-main.cs
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    
    class Program
    {
        static void Main(string[] args)
        {
            var num = 10;
            var myList = new List<int>();
    
            Obj.Print(num);
            Console.WriteLine("-----------------");
            Obj.Print(myList);
        }
    }
    carrie@ubuntu:~/0x08-csharp-inheritance/3-type_get$
```    
```
    carrie@ubuntu:~/0x08-csharp-inheritance/3-type_get$ ls
    3-type_get.cs  3-type_get.csproj  3-main.cs  bin  obj
    carrie@ubuntu:~/0x08-csharp-inheritance/3-type_get$ dotnet run
    Int32 Properties:
    Int32 Methods:
    CompareTo
    CompareTo
    Equals
    Equals
    GetHashCode
    ToString
    ToString
    ToString
    ToString
    Parse
    Parse
    Parse
    Parse
    TryParse
    TryParse
    GetTypeCode
    GetType
    -----------------
    List`1 Properties:
    Capacity
    Count
    Item
    List`1 Methods:
    get_Capacity
    set_Capacity
    get_Count
    get_Item
    set_Item
    Add
    AddRange
    AsReadOnly
    BinarySearch
    BinarySearch
    BinarySearch
    Clear
    Contains
    ConvertAll
    CopyTo
    CopyTo
    CopyTo
    Exists
    Find
    FindAll
    FindIndex
    FindIndex
    FindIndex
    FindLast
    FindLastIndex
    FindLastIndex
    FindLastIndex
    ForEach
    GetEnumerator
    GetRange
    IndexOf
    IndexOf
    IndexOf
    Insert
    InsertRange
    LastIndexOf
    LastIndexOf
    LastIndexOf
    Remove
    RemoveAll
    RemoveAt
    RemoveRange
    Reverse
    Reverse
    Sort
    Sort
    Sort
    Sort
    ToArray
    TrimExcess
    TrueForAll
    ToString
    Equals
    GetHashCode
    GetType
    carrie@ubuntu:~/0x08-csharp-inheritance/3-type_get$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x08-csharp-inheritance`
*   File: `3-type_get/, 3-type_get/3-type_get.csproj, 3-type_get/3-type_get.cs`



#### Students who are done with "4. It's not a lesson in classes and inheritance without a Dog"

#### 4\. It's not a lesson in classes and inheritance without a Dog mandatory

Write a empty class `Dog` that inherits from empty class `Animal`.

*   Base Class: `Animal`
*   Derived Class: `Dog`
```
    carrie@ubuntu:~/0x08-csharp-inheritance/4-inherit$ cat 4-main.cs
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Dog myDog = new Dog();
            object obj = myDog;
            Animal anotherAnimal = myDog;
    
            Console.WriteLine("myAnimal is a {0}", myAnimal.GetType());
            Console.WriteLine("myDog is a {0}", myDog.GetType());
            Console.WriteLine("obj is a {0}", obj.GetType());
            Console.WriteLine("anotherAnimal is a {0}", anotherAnimal.GetType());
        }
    }
    carrie@ubuntu:~/0x08-csharp-inheritance/4-inherit$
```    
```
    carrie@ubuntu:~/0x08-csharp-inheritance/4-inherit$ ls
    4-inherit.cs  4-inherit.csproj  4-main.cs  bin  obj
    carrie@ubuntu:~/0x08-csharp-inheritance/4-inherit$ dotnet run
    myAnimal is a Animal
    myDog is a Dog
    obj is a Dog
    anotherAnimal is a Dog
    carrie@ubuntu:~/0x08-csharp-inheritance/4-inherit$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x08-csharp-inheritance`
*   File: `4-inherit/, 4-inherit/4-inherit.cs, 4-inherit/4-inherit.csproj`



#### Students who are done with "5. Basic shapes"

#### 5\. Basic shapes mandatory

Write a class `Shape`.

*   Class: `Shape`
    *   public method: `public virtual int Area()`
        *   Throws an `NotImplementedException` with the message `Area() is not implemented`
```
    carrie@ubuntu:~/0x08-csharp-inheritance/5-shape$ cat 5-main.cs
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Shape aShape = new Shape();
    
            try
            {
                Console.WriteLine("Area: {0}", aShape.Area());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
    carrie@ubuntu:~/0x08-csharp-inheritance/5-shape$
```    
```
    carrie@ubuntu:~/0x08-csharp-inheritance/5-shape$ ls
    5-shape.cs  5-shape.csproj  5-main.cs  bin  obj
    carrie@ubuntu:~/0x08-csharp-inheritance/5-shape$ dotnet run
    System.NotImplementedException: Area() is not implemented
    ...
    carrie@ubuntu:~/0x08-csharp-inheritance/5-shape$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x08-csharp-inheritance`
*   File: `5-shape/, 5-shape/5-shape.csproj, 5-shape/5-shape.cs`



#### Students who are done with "6. Rectangle"

#### 6\. Rectangle mandatory

Based on `5-shape`, write a class `Rectangle` that inherits from `Shape`.

*   Class: `Rectangle`
    *   private field: `private int width`
    *   private field: `private int height`
    *   public property: `public int Width`
        *   `get`: retrieve `width`
        *   `set`: if value is negative, throw an `ArgumentException` with the message `Width must be greater than or equal to 0`. Otherwise, set `width` to the value.
    *   public property: `public int Height`
        *   `get`: retrieve `height`
        *   `set`: if value is negative, throw an `ArgumentException` with the message `Height must be greater than or equal to 0`. Otherwise, set `Height` to the value.
```
    carrie@ubuntu:~/0x08-csharp-inheritance/6-shape$ cat 6-main.cs
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle aRect = new Rectangle();
            aRect.Width = 10;
            aRect.Height = 2;
    
            if (typeof(Rectangle).IsSubclassOf(typeof(Shape)))
                Console.WriteLine("Rectangle is a subclass of Shape");
            else
                Console.WriteLine("Rectangle is a NOT subclass of Shape");
    
            Console.WriteLine("Width: {0}", aRect.Width);
            Console.WriteLine("Height: {0}", aRect.Height);
    
            try
            {
                Console.WriteLine("Area: {0}", aRect.Area());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
    carrie@ubuntu:~/0x08-csharp-inheritance/6-shape$
```    
```
    carrie@ubuntu:~/0x08-csharp-inheritance/6-shape$ ls
    6-shape.cs  6-shape.csproj  6-main.cs  bin  obj
    carrie@ubuntu:~/0x08-csharp-inheritance/6-shape$ dotnet run
    Rectangle is a subclass of Shape
    Width: 10
    Height: 2
    System.NotImplementedException: Area() is not implemented
    ...
    carrie@ubuntu:~/0x08-csharp-inheritance/6-shape$
 ```   

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x08-csharp-inheritance`
*   File: `6-shape/, 6-shape/6-shape.csproj, 6-shape/6-shape.cs`



#### Students who are done with "7. Full rectangle"

#### 7\. Full rectangle mandatory

Based on `6-shape`, write a class `Rectangle` that inherits from `Shape`.

*   Class: `Rectangle`
    *   private field: `private int width`
    *   private field: `private int height`
    *   public property: `public int Width`
        *   `get`: retrieve `width`
        *   `set`: if value is negative, throw an `ArgumentException` with the message `Width must be greater than or equal to 0`. Otherwise, set `width` to the value.
    *   public property: `public int Height`
        *   `get`: retrieve `height`
        *   `set`: if value is negative, throw an `ArgumentException` with the message `Height must be greater than or equal to 0`. Otherwise, set `Height` to the value.
    *   public method: `public new int Area()`
        *   This will override the `Area()` method defined in the `Shape` base class. (Try changing `new` to `override` and run the program. What happens?) returns the area of the rectangle
    *   public method: `public override ToString()`
        *   returns `[Rectangle] <width> / <height>`
```
    carrie@ubuntu:~/0x08-csharp-inheritance/7-shape$ cat 7-main.cs
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle aRect = new Rectangle();
    
            aRect.Width = 7;
            aRect.Height = 4;
    
            Console.WriteLine("Area: {0}", aRect.Area());
            Console.WriteLine(aRect.ToString());
        }
    }
    carrie@ubuntu:~/0x08-csharp-inheritance/7-shape$
```    
```
    carrie@ubuntu:~/0x08-csharp-inheritance/7-shape$ ls
    7-shape.cs  7-shape.csproj  7-main.cs  bin  obj
    carrie@ubuntu:~/0x08-csharp-inheritance/7-shape$ dotnet run
    Area: 28
    [Rectangle] 7 / 4
    carrie@ubuntu:~/0x08-csharp-inheritance/7-shape$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x08-csharp-inheritance`
*   File: `7-shape/, 7-shape/7-shape.csproj, 7-shape/7-shape.cs`



#### Students who are done with "8. Square #1"

#### 8\. Square #1 mandatory

Based on `7-shape`, write a class `Square` that inherits from `Rectangle`

*   Class: `Square`
    *   private field: `private int size`
    *   public property: `public int Size`
        *   `get`: retrieve `size`
        *   `set`: if value is negative, throw an `ArgumentException` with the message `Size must be greater than or equal to 0`. Otherwise, set `size`, `height`, and `width` to the value.
```
    carrie@ubuntu:~/0x08-csharp-inheritance/8-shape$ cat 8-main.cs
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Square aSquare = new Square();
    
            aSquare.Size = 10;
    
            if (typeof(Square).IsSubclassOf(typeof(Shape)))
                Console.WriteLine("Square is a subclass of Shape");
            else
                Console.WriteLine("Square is a NOT subclass of Shape");
    
            Console.WriteLine("Size: {0}", aSquare.Size);
        }
    }
    carrie@ubuntu:~/0x08-csharp-inheritance/8-shape$
```    
```
    carrie@ubuntu:~/0x08-csharp-inheritance/8-shape$ ls
    8-shape.cs  8-shape.csproj  8-main.cs  bin  obj
    carrie@ubuntu:~/0x08-csharp-inheritance/8-shape$ dotnet run
    Square is a subclass of Shape
    Size: 10
    carrie@ubuntu:~/0x08-csharp-inheritance/8-shape$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x08-csharp-inheritance`
*   File: `8-shape/, 8-shape/8-shape.csproj, 8-shape/8-shape.cs`



#### Students who are done with "9. Square #2"

#### 9\. Square #2 mandatory

Based on `8-shape`, write a class `Square` that inherits from `Rectangle`

*   Class: `Square`
    *   private field: `private int size`
    *   public property: `public int Size`
        *   `get`: retrieve `size`
        *   `set`: if value is negative, throw an `ArgumentException` with the message `Size must be greater than or equal to 0`. Otherwise, set `size`, `Height`, and `Width` to the value.
    *   `Area()` should work **without** writing a new `Area()` method within your `Square` class
    *   `.ToString()` should return `[Square] <size> / <size>`
```
    carrie@ubuntu:~/0x09-csharp-inheritance/9-shape$ cat 9-main.cs
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle aRect = new Rectangle();
            aRect.Width = 6;
            aRect.Height = 8;
            Console.WriteLine("aRect width: {0}", aRect.Width);
            Console.WriteLine("aRect height: {0}", aRect.Height);
            Console.WriteLine("aRect area: {0}", aRect.Area());
            Console.WriteLine(aRect.ToString());
    
            Console.WriteLine("------------------");
    
            Square aSquare = new Square();
            aSquare.Size = 12;
            Console.WriteLine("aSquare width: {0}", aSquare.Width);
            Console.WriteLine("aSquare height: {0}", aSquare.Height);
            Console.WriteLine("aSquare area: {0}", aSquare.Area());
            Console.WriteLine(aSquare.ToString());
        }
    }
    carrie@ubuntu:~/0x09-csharp-inheritance/9-shape$
```    
```
    carrie@ubuntu:~/0x09-csharp-inheritance/9-shape$ ls
    9-shape.cs  9-shape.csproj  9-main.cs  bin  obj
    carrie@ubuntu:~/0x09-csharp-inheritance/9-shape$ dotnet run
    aRect width: 6
    aRect height: 8
    aRect area: 48
    [Rectangle] 6 / 8
    ------------------
    aSquare width: 12
    aSquare height: 12
    aSquare area: 144
    [Square] 12 / 12
    carrie@ubuntu:~/0x09-csharp-inheritance/9-shape$
 ```   

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x08-csharp-inheritance`
*   File: `9-shape/, 9-shape/9-shape.csproj, 9-shape/9-shape.cs`



#### Students who are done with "10. Liskov"

#### 10\. Liskov mandatory

In the previous tasks, we created a class `Square` that inherits from `Rectangle`. However, what happens if you try to assign a Square’s `width` and `height` directly:

    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Square aSquare = new Square();
    
            try
            {
                aSquare.Width = 12;
                aSquare.Height = 8;
    
                Console.WriteLine("aSquare width: {0}", aSquare.Width);
                Console.WriteLine("aSquare height: {0}", aSquare.Height);
                Console.WriteLine("aSquare size: {0}", aSquare.Size);
                Console.WriteLine("aSquare area: {0}", aSquare.Area());
                Console.WriteLine(aSquare.ToString());
            }
            catch (Exception e)
            {            
                Console.WriteLine(e);
            }
        }
    }
    

Here we see there’s a flaw in our implementation of `Square` as inheriting from `Rectangle`. This is because this hierarchy violates [Liskov’s substitution principle](https://en.wikipedia.org/wiki/Behavioral_subtyping "Liskov's substitution principle"). What would the ideal hierarchy involving `Shape`, `Rectangle`, and `Square` look like instead?

Write a blog post that explains the problem with implementing a `Square` class as a derived class of `Rectangle`. It should cover:

*   what Liskov’s substitution principle is
*   why `Square` inheriting from `Rectangle` is not an ideal design choice
*   ways that this class hierarchy could be improved

Your posts should have examples and at least one picture, at the top. Publish your blog post on Medium or LinkedIn, and share it at least on Twitter and LinkedIn.

Please, remember that these blogs must be written in English to further your technical ability in a variety of settings.

#### Add URLs here:[ ________________________________________________________]

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x08-csharp-inheritance`