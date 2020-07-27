# 0x00. C# - Hello, World - 04-13-2020

<img alt="C#" src="../logo.jpg" width=70% height=70%>

**What I learned from this project**

* What is the meaning behind the name C#?
1. C++++
2. Inspired from musical notation where a sharp indicates that the written note should be made a half-step higher in pitch

*	Who is the lead architect of the development team of C#?
1. Anders Hejlseberg

*	What is .NET?
1. a software framework developed by Microsoft

*	What is the difference between C# and .NET?
1. C# is a programming language, . NET is the framework that the language is built on. 
2. C# is a strong Object Oriented programming language that is mostly built on the . NET framework.

*	How to use VSCode and the integrated terminal to initialize, build, and run C# projects
1. Initialize: dotnet new console
build: dotnet build
run: dotnet run

*	How to print text and variables using Console.Write
1. Console.write("Date: {0:d}:\n   Temperature at {1:t}: {2}\n   Temperature at {3:t}: {4}\n", dateRecorded, startTime, temperature1, startTime.Add(interval), temperature2);

*	How to print text and variables using Console.WriteLine
1. Console.WriteLine("{0} {1} {2}", number1, number2, number3);

*	What is Intermediate Language (IL) code?
1. a language used by .NET Framework to generate machine-independent code
a language with a purpose similar to Java bytecode

*	What is CLR?
1. Common Language Runtime

_For this project, students are expected to look at these concepts:_


*   [Install Visual Studio Code](https://code.visualstudio.com/)
*   [Install the .NET Core 2.1 LTS SDK (SDK, not Runtime)](https://dotnet.microsoft.com/download/dotnet-core)
*   [Install the C# extension from the Visual Studio Code Marketplace](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)


Resources
---------

**Read or watch**:

*   [Introduction to the C# Language and the .NET Framework](https://docs.microsoft.com/en-us/dotnet/csharp/getting-started/introduction-to-the-csharp-language-and-the-net-framework "Introduction to the C# Language and the .NET Framework")
*   [Get started with C# and Visual Studio Code](https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code "Get started with C# and Visual Studio Code")
*   [Getting Started with .NET Core using the CLI](https://docs.microsoft.com/en-us/dotnet/core/tutorials/cli-create-console-app "Getting Started with .NET Core using the CLI")
*   [C# Tutorial for Beginners]((https://www.youtube.com/watch?v=gfkTfcpWqAY&feature=youtu.be&t=1m20s) "C# Tutorial for Beginners") (_1:20 - 5:18_)
*   [Strings (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/ "Strings (C# Programming Guide)")
*   [C# Language Reference](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/ "C# Language Reference")
*   [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions "C# Coding Conventions")
*   [Console.WriteLine Method](https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.8 "Console.WriteLine Method")


Requirements
------------

### Shell Scripts

*   Allowed editors: `vi`, `vim`, `emacs`
*   All your scripts will be tested on Ubuntu 14.04 LTS
*   All your files should end with a new line
*   The first line of all your files should be exactly `#!/usr/bin/env bash`
*   All your files must be executable

### C# Tasks

*   Allowed editors: `Visual Studio Code`
*   All files will be compiled on Ubuntu 14.04 LTS using `dotnet`
*   A `README.md` file, at the root of the folder of the project, is mandatory
*   All default C# files named `Program.cs` should be renamed to the name given in each task
*   You do not need to know about namespaces and classes yet. Namespaces should be omitted in this project. The default names generated in `Program.cs` for `class` are okay
*   Each C# task requires its own folder and `.csproj` file. Push all task folders to your Github and ensure the task names on the folders are correct
*   You do not need to push your `obj/` or `bin/` folders

* * *

Quiz questions
--------------

#### Question #0

What is the meaning behind the name C#?

- [x]   C++++
    
- [ ]   C Hash
    
- [x]   Inspired from musical notation where a sharp indicates that the written note should be made a half-step higher in pitch
    

#### Question #1

Who is the lead architect of the development team of C#?

- [ ]   Bill Gates
    
- [x]   Anders Hejlseberg
    
- [ ]   James Gosling
    

#### Question #2

What is .NET framework?

- [ ]   a web development tool
    
- [ ]   a generic top-level domain used in DNS
    
- [x]   a software framework developed by Microsoft
    

#### Question #3

What is CLR?

- [x]   Common Language Runtime
    
- [ ]   C# Language Reader
    
- [ ]   Clear
    

#### Question #4

What is Intermediate Language (IL) code?

- [x]   a language used by .NET Framework to generate machine-independent code
    
- [ ]   a language that is more difficult to learn
    
- [x]   a language with a purpose similar to Java bytecode
    

#### Question #5

What method is used for writing text to standard output with a new line?

- [ ]   Console.Write()
    
- [ ]   Console.Print()
    
- [x]   Console.WriteLine()
    

#### Question #6

What method is used for writing text to standard output without a new line?

- [x]   Console.Write()
    
- [ ]   Console.Print()
    
- [ ]   Console.WriteLine()
    

#### Question #7

What does the following code display?

    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            Console.WriteLine("{0} {1} {2}", number1, number2, number3);
        }
    }
    

- [ ]   0 1 2
    
- [ ]   1 2 3
    
- [ ]   number1 number2 number3
    

#### Question #8

What does the following code display?

    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            Console.WriteLine("{2} {0} {1}", number1, number2, number3);
        }
    }
    

- [ ]   3 1 2
    
- [ ]   number2, number1, number2
    
- [ ]   2 0 1
    
- [ ]   1 2 3
    

* * *

Tasks
-----


#### Students who are done with "0. Initialize new project"

#### [0. Initialize new project](./0-initialize_new_project.sh)



Write a Bash script that initializes a new C# project inside a folder titled `0-new_project`.

*   Use the command `dotnet`

```
    carrie@ubuntu:~/0x00-csharp-hello_world/$ ls
    0-initialize_new_project.sh
    carrie@ubuntu:~/0x00-csharp-hello_world/$ ./0-initialize_new_project.sh 
    The template "Console Application" was created successfully.
    
    Processing post-creation actions...
    Running 'dotnet restore' on /home/carrie/0x00-csharp-hello_world/0-new_project/0-new_project.csproj...
      Restoring packages for /home/carrie/0x00-csharp-hello_world/0-new_project/0-new_project.csproj...
      Generating MSBuild file /home/carrie/0x00-csharp-hello_world/0-new_project/obj/0-new_project.csproj.nuget.g.props.
      Generating MSBuild file /home/carrie/0x00-csharp-hello_world/0-new_project/obj/0-new_project.csproj.nuget.g.targets.
      Restore completed in 151.49 ms for /home/carrie/0x00-csharp-hello_world/0-new_project/0-new_project.csproj.
    
    
    Restore succeeded.
    
    carrie@ubuntu:~/0x00-csharp-hello_world/$ ls
    0-initialize_new_project.sh  0-new_project
    carrie@ubuntu:~/0x00-csharp-hello_world/$ ls 0-new_project/
    0-new_project.csproj  obj  Program.cs
    carrie@ubuntu:~/0x00-csharp-hello_world/0-new_project$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x00-csharp-hello_world`
*   File: `0-initialize_new_project.sh`


#### Students who are done with "1. Build new project"

#### [1. Build new project ](./1-build_new_project.sh)

Write a Bash script that initializes and builds a new C# project inside a folder titled `1-new_project`.

*   Use the command `dotnet`
```
    carrie@ubuntu:~/0x00-csharp-hello_world$ ls
    1-build_new_project.sh
    carrie@ubuntu:~/0x00-csharp-hello_world$ ./1-build_new_project.sh 
    The template "Console Application" was created successfully.
    
    Processing post-creation actions...
    Running 'dotnet restore' on /home/carrie/0x00-csharp-hello_world/1-new_project/1-new_project.csproj...
      Restoring packages for /home/carrie/0x00-csharp-hello_world/1-new_project/1-new_project.csproj...
      Generating MSBuild file /home/carrie/0x00-csharp-hello_world/1-new_project/obj/1-new_project.csproj.nuget.g.props.
      Generating MSBuild file /home/carrie/0x00-csharp-hello_world/1-new_project/obj/1-new_project.csproj.nuget.g.targets.
      Restore completed in 149.24 ms for /home/carrie/0x00-csharp-hello_world/1-new_project/1-new_project.csproj.
    
    
    Restore succeeded.
    
    Microsoft (R) Build Engine version 15.4.8.50001 for .NET Core
    Copyright (C) Microsoft Corporation. All rights reserved.
    
      1-new_project -> /home/carrie/0x00-csharp-hello_world/1-new_project/bin/Debug/netcoreapp2.1/1-new_project.dll
    
    Build succeeded.
        0 Warning(s)
        0 Error(s)
    
    Time Elapsed 00:00:02.21
    carrie@ubuntu:~/0x00-csharp-hello_world$ ls
    1-build_new_project.sh  1-new_project
    carrie@ubuntu:~/0x00-csharp-hello_world$ ls 1-new_project/
    1-new_project.csproj  bin  obj  Program.cs
    carrie@ubuntu:~/0x00-csharp-hello_world$ 
    
```
**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x00-csharp-hello_world`
*   File: `1-build_new_project.sh`



#### Students who are done with "2. Run new project"

#### [2. Run new project](./2-run_new_project.sh)


Write a Bash script that initializes, builds, and runs a new C# project from a folder titled `2-new_project`.

*   Use the command `dotnet`
```
    carrie@ubuntu:~/0x00-csharp-hello_world$ ls
    2-run_new_project.sh
    carrie@ubuntu:~/0x00-csharp-hello_world$ ./2-run_new_project.sh 
    The template "Console Application" was created successfully.
    
    Processing post-creation actions...
    Running 'dotnet restore' on /home/carrie/0x00-csharp-hello_world/2-new_project/2-new_project.csproj...
      Restoring packages for /home/carrie/0x00-csharp-hello_world/2-new_project/2-new_project.csproj...
      Generating MSBuild file /home/carrie/0x00-csharp-hello_world/2-new_project/obj/2-new_project.csproj.nuget.g.props.
      Generating MSBuild file /home/carrie/0x00-csharp-hello_world/2-new_project/obj/2-new_project.csproj.nuget.g.targets.
      Restore completed in 154.48 ms for /home/carrie/0x00-csharp-hello_world/2-new_project/2-new_project.csproj.
    
    
    Restore succeeded.
    
    Microsoft (R) Build Engine version 15.4.8.50001 for .NET Core
    Copyright (C) Microsoft Corporation. All rights reserved.
    
      2-new_project -> /home/carrie/0x00-csharp-hello_world/2-new_project/bin/Debug/netcoreapp2.1/2-new_project.dll
    
    Build succeeded.
        0 Warning(s)
        0 Error(s)
    
    Time Elapsed 00:00:02.21
    Hello World!
    carrie@ubuntu:~/0x00-csharp-hello_world$ ls
    2-new_project  2-run_new_project.sh
    carrie@ubuntu:~/0x00-csharp-hello_world$ ls 2-new_project/
    2-new_project.csproj  bin  obj  Program.cs
    carrie@ubuntu:~/0x00-csharp-hello_world$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x00-csharp-hello_world`
*   File: `2-run_new_project.sh`


#### Students who are done with "3. Hello, WriteLine"

#### [3. Hello, WriteLine ](./3-writeline)



Write a C# script that prints exactly `"Programming is like building a multilingual puzzle` followed by a new line.

*   Use the method `Console.WriteLine`
```
    carrie@ubuntu:~/0x00-csharp-hello_world/3-writeline$ ls
    3-writeline.csproj  bin  obj  3-writeline.cs
    carrie@ubuntu:~/0x00-csharp-hello_world/3-writeline$ dotnet run
    "Programming is like building a multilingual puzzle
    carrie@ubuntu:~/0x00-csharp-hello_world/3-writeline$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x00-csharp-hello_world`
*   File: `3-writeline/, 3-writeline/3-writeline.csproj, 3-writeline/3-writeline.cs`


#### Students who are done with "4. Print integer"

#### [4. Print integer](./4-print_integer)



Complete this 
```
using System;

class Program
{
	static void Main(string[] args)
	{
		int number = 972;
		// YOUR CODE GOES HERE. PLEASE REMOVE THIS LINE.
	}
}
```
in order to print the integer stored in the variable `number`, followed by `Mission Street` followed by a new line.

*   Your code should be exactly 10 lines long
*   The output of the script should be:
    *   the number, followed by `Mission Street`
    *   followed by a new line
```
    carrie@ubuntu:~/0x00-csharp-hello_world/4-print_integer$  ls
    4-print_integer.cs  4-print_integer.csproj  bin  obj
    carrie@ubuntu:~/0x00-csharp-hello_world/4-print_integer$ dotnet run
    972 Mission Street
    carrie@ubuntu:~/0x00-csharp-hello_world/4-print_integer$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x00-csharp-hello_world`
*   File: `4-print_integer/, 4-print_integer/4-print_integer.csproj, 4-print_integer/4-print_integer.cs`



#### Students who are done with "5. Print float"

#### [5. Print float](./5-print_float)



Complete this
```using System;

class Program
{
	static void Main(string[] args)
        {
		float number = 3.14159f;
		// YOUR CODE GOES HERE. PLEASE REMOVE THIS LINE.
        }
}
```
in order to print the float stored in the variable `number` with a precision of 2 digits.

*   Your script should be exactly 10 lines long
*   The output of the script should be:
    *   `Float:` followed by the number with only 2 digits
    *   followed by a new line
```
    carrie@ubuntu:~/0x00-csharp-hello_world/5-print_float$ ls
    5-print_float.cs  5-print_float.csproj  bin  obj
    carrie@ubuntu:~/0x00-csharp-hello_world/5-print_float$ dotnet run
    Float: 3.14
    carrie@ubuntu:~/0x00-csharp-hello_world/5-print_float$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x00-csharp-hello_world`
*   File: `5-print_float/, 5-print_float/5-print_float.csproj, 5-print_float/5-print_float.cs`



#### Students who are done with "6. Print string"

#### [6. Print string](./6-print_string)



Complete this
```
using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		// YOUR CODE GOES HERE. PLEASE REMOVE THIS LINE.
        }
}
```
in order to print a string stored in the variable `str` 3 times, followed by its first 9 characters.

*   The output of the script should be:
    *   the value of `str` 3 times
    *   followed by a new line
    *   followed by the first 9 characters of `str`
    *   followed by a new line
*   You are not allowed to use any loops or conditional statement
```
    carrie@ubuntu:~/0x00-csharp-hello_world/6-print_string$ ls
    6-print_string.cs  6-print_string.csproj  bin  obj
    carrie@ubuntu:~/0x00-csharp-hello_world/6-print_string$ dotnet run
    Holberton SchoolHolberton SchoolHolberton School
    Holberton
    carrie@ubuntu:~/0x00-csharp-hello_world/6-print_string$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x00-csharp-hello_world`
*   File: `6-print_string/, 6-print_string/6-print_string.csproj, 6-print_string/6-print_string.cs`



#### Students who are done with "7. Play with strings"

#### [7. Play with strings ](./7-concat)



Complete this
```
using System;

class Program
{
	static void Main(string[] args)
	{
		string str1 = "Holberton";
		string str2 = "School";
		// YOUR CODE GOES HERE. PLEASE REMOVE THIS LINE.
		Console.WriteLine("Welcome to {0}!", str1);
	}
}
```
to print `Welcome to Holberton School!`

*   Your code should be exactly 12 lines long
*   You are not allowed to use any loops or conditional statement
*   You have to use the variables `str1` and `str2` in your new line of code
```
    carrie@ubuntu:~/0x00-csharp-hello_world/7-concat$ ls
    7-concat.cs  7-concat.csproj  bin  obj
    carrie@ubuntu:~/0x00-csharp-hello_world/7-concat$ dotnet run
    Welcome to Holberton School!
    carrie@ubuntu:~/0x00-csharp-hello_world/7-concat$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x00-csharp-hello_world`
*   File: `7-concat/, 7-concat/7-concat.csproj, 7-concat/7-concat.cs`



#### Students who are done with "8. Print variables"

#### [8. Print variables](./8-print_variables)



Complete this
```
using System;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "Street";
        string str2 = "Mission";
        int int1 = 972;
        // YOUR CODE GOES HERE. PLEASE REMOVE THIS LINE.
    }
}
```
in order to print the given variables as `972 Mission Street`.

*   Your code should be exactly 12 lines long
*   You are not allowed to create new variables
*   You are not allowed to edit existing variables
*   The output of the script should be:
    *   `972 Mission Street`
    *   followed by a new line
```
    carrie@ubuntu:~/0x00-csharp-hello_world/8-print_variables$ ls
    8-print_variables.cs  8-print_variables.csproj  bin  obj
    carrie@ubuntu:~/0x00-csharp-hello_world/8-print_variables$ dotnet run
    972 Mission Street
    carrie@ubuntu:~/0x00-csharp-hello_world/8-print_variables$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x00-csharp-hello_world`
*   File: `8-print_variables/, 8-print_variables/8-print_variables.csproj, 8-print_variables/8-print_variables.cs`



#### Students who are done with "9. Print specifiers"

#### [9. Print specifiers ](./9-print_specifiers)



Complete this
```
using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		// YOUR CODE GOES HERE. PLEASE REMOVE THIS LINE.
	}
}
```
in order to print the given variables as in the result shown.

*   Your code should be no more than 12 lines long
*   You are not allowed to create new variables
*   The target locale is `en-US.utf-8`
*   The output of the script should be:
    *   `Percent: 75.53%` [tip](/https://www.dotnetperls.com/percentage "tip")
    *   followed by a new line
    *   followed by `Currency: $98,765.43`
    *   followed by a new line
```
    carrie@ubuntu:~/0x00-csharp-hello_world/9-print_specifiers$ ls
    9-print_specifiers.cs  9-print_specifiers.csproj  bin  obj
    carrie@ubuntu:~/0x00-csharp-hello_world/9-print_specifiers$ dotnet run
    Percent: 75.53%
    Currency: $98,765.43
    carrie@ubuntu:~/0x00-csharp-hello_world/9-print_specifiers$ 
    
```
**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x00-csharp-hello_world`
*   File: `9-print_specifiers/, 9-print_specifiers/9-print_specifiers.csproj, 9-print_specifiers/9-print_specifiers.cs`



#### Students who are done with "10. Copy - Cut - Paste"

#### [10. Copy - Cut - Paste ](./10-copy_cut_paste)



Complete this
```
using System;

class Program
{
        static void Main(string[] args)
        {
		string word = "Holberton";
		// YOUR CODE GOES HERE. PLEASE REMOVE THIS LINE
		Console.WriteLine("First 3 letters: {0}", word_first_3);
		Console.WriteLine("Last 2 letters: {0}", word_last_2);
		Console.WriteLine("Middle word: {0}", middle_word);
        }
}
```
*   Your code should be exactly 15 lines long
*   You are not allowed to use any loops or conditional statements
*   `word_first_3` should contain the first 3 letters of the variable `word`
*   `word_last_2` should contain the last 2 letters of the variable `word`
*   `middle_word` should contain the value of the variable `word` without the first and last letters
```
    carrie@ubuntu:~/0x00-csharp-hello_world/10-copy_cut_paste$ ls
    10-copy_cut_paste.cs  10-copy_cut_paste.csproj  bin  obj
    carrie@ubuntu:~/0x00-csharp-hello_world/10-copy_cut_paste$ dotnet run
    First 3 letters: Hol
    Last 2 letters: on
    Middle word: olberto
    carrie@ubuntu:~/0x00-csharp-hello_world/10-copy_cut_paste$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x00-csharp-hello_world`
*   File: `10-copy_cut_paste/, 10-copy_cut_paste/10-copy_cut_paste.csproj, 10-copy_cut_paste/10-copy_cut_paste.cs`



#### Students who are done with "11. Create a new sentence"

#### [11. Create a new sentence](./11-concat_edges)



Complete this
```
using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
		// YOUR CODE GOES HERE. PLEASE REMOVE THIS LINE.
		Console.WriteLine(str);
        }
}
```
to print `object-oriented programming in C#` followed by a new line.

*   Your code should be exactly 11 lines long
*   You are not allowed to use any loops or conditional statements
*   You are not allowed to create new variables
*   You are not allowed to use string literals
```
    carrie@ubuntu:~/0x00-csharp-hello_world/11-concat_edges$ ls
    11-concat_edges.cs  11-concat_edges.csproj  bin  obj
    carrie@ubuntu:~/0x00-csharp-hello_world/11-concat_edges$ dotnet run
    object-oriented programming in C#
    carrie@ubuntu:~/0x00-csharp-hello_world/11-concat_edges$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x00-csharp-hello_world`
*   File: `11-concat_edges/, 11-concat_edges/11-concat_edges.csproj, 11-concat_edges/11-concat_edges.cs`
#### 11\. Create a new sentence



#### Students who are done with "12. Hello, Error"

#### [12. Hello, Error](./100-hello_error)



Write a C# script that prints exactly `and that piece of art is useful - Dora Korpar, 2015-10-19` followed by a new line.

*   Your script should print to `stderr`
*   Your script should exit with the status code `1`
```
    carrie@ubuntu:~/0x00-csharp-hello_world/100-hello_error$ ls
    100-hello_error.cs  100-hello_error.csproj  obj
    carrie@ubuntu:~/0x00-csharp-hello_world/100-hello_error$ dotnet run
    and that piece of art is useful - Dora Korpar, 2015-10-19
    carrie@ubuntu:~/0x00-csharp-hello_world/100-hello_error$ echo $?
    1
    carrie@ubuntu:~/0x00-csharp-hello_world/100-hello_error$ dotnet run 2> q
    carrie@ubuntu:~/0x00-csharp-hello_world/100-hello_error$ cat q
    and that piece of art is useful - Dora Korpar, 2015-10-19
    carrie@ubuntu:~/0x00-csharp-hello_world/100-hello_error$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x00-csharp-hello_world`
*   File: `100-hello_error/, 100-hello_error/100-hello_error.csproj, 100-hello_error/100-hello_error.cs`

