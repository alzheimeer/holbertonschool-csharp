0x01. C# - if/else, loops, functions
====================================

Resources
---------

**Read or watch**:

*   [if-else (C# Reference)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else "if-else (C# Reference)")
*   [Control Statements - Loops](https://csharp-station.com/Tutorial/CSharp/Lesson04 "Control Statements - Loops") (_You do not need to know `foreach` yet_)
*   [Methods (C# Reference)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods "Methods (C# Reference)") (_Read up to “Async Methods”_)
*   [Standard Numeric Format Strings](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings "Standard Numeric Format Strings")
*   [Iteration Statements](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/statement-keywords "Iteration Statements")
*   [C# Language Reference](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/ "C# Language Reference")
*   [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions "C# Coding Conventions")

### General

*   How to use `if`, `else if`, `else` statements
*   How to use `while` and `for` loops
*   How to use `break` and `continue` statements
*   How to use numeric format strings
*   How to declare methods within a class
*   How to call public methods from another class
*   What is passing by reference and passing by value

Requirements
------------

### C# Tasks

*   Allowed editors: `Visual Studio Code`
*   All files will be compiled on Ubuntu 14.04 LTS using `dotnet`
*   A `README.md` file, at the root of the folder of the project, is mandatory
*   All default C# files named `Program.cs` should be renamed to the name given in each task
*   You do not need to know about namespaces and classes yet. Namespaces should be omitted in this project
*   Each C# task requires its own folder and `.csproj` file. Push all task folders to your Github and ensure the task names on the folders are correct
*   You do not need to push your `obj/` or `bin/` folders
*   In the following examples, the `main.cs` files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own `main.cs` files at compilation. Our `main.cs` files might be different from the one shown in the examples

* * *

Quiz questions
--------------

#### Question #0

What format string displays `9876.678` as `9876.68`?

- [ ]   `G2`
    
- [ ]   `N2`
    
- [X]   `F2`
    
- [ ]   `E2`
    

#### Question #1

What format string displays `9876.678` as `9,876.68`?

- [X]   `N2`
    
- [ ]   `F2`
    
- [ ]   `D2`
    
- [ ]   `C2`
    

#### Question #2

What format string displays `255` as `FF`

- [ ]   `F`
    
- [ ]   `G`
    
- [ ]   `D`
    
- [X]   `X`
    

#### Question #3

What format string displays `.753` as `75.30%`?

- [ ]   `P`
    
- [ ]   `P0`
    
- [ ]   `P1`
    
- [X]   `P2`
    

#### Question #4

What format string displays `.753` as `75%`?

- [ ]   `P`
    
- [X]   `P0`
    
- [ ]   `P1`
    
- [ ]   `P2`
    

#### Question #5

What format string displays `8.2` as `$8.20`?

- [X]   `C`
    
- [ ]   `C0`
    
- [ ]   `C1`
    
- [X]   `C2`
    

#### Question #6

What does this code display?

    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            if (num > 0)
                Console.WriteLine("Holberton");
            else
                Console.WriteLine("School");
        }
    }
    

- [X]   Holberton
    
- [ ]   School
    

#### Question #7

What does this code display?

    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            if (num % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
    }
    

- [X]   Even
    
- [ ]   Odd
    

#### Question #8

What does this code display?

    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            if (num > 0)
                Console.WriteLine("972");
            else if (num < 0)
                Console.WriteLine("Mission");
            else
                Console.WriteLine("Street");
        }
    }
    

- [ ]   972
    
- [ ]   Mission
    
- [X]   Street
    

#### Question #9

What does this code display?

    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 4; i++)
                Console.Write(i);
        }
    }
    

- [ ]   1234
    
- [X]   0123
    
- [ ]   1 2 3 4
    
- [ ]   0 1 2 3
    

#### Students who are done with "0. Positive anything is better than negative nothing"

#### 0\. Positive anything is better than negative nothing mandatory



This program will assign a random signed number to the variable `number` each time it is executed. Complete the 
```
using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
	// YOUR CODE GOES HERE. PLEASE REMOVE THIS LINE
    }
}
```
in order to print whether the number stored in the variable `number` is positive or negative.

*   The variable `number` will store a different value every time you will run this program
*   You don’t have to understand what `Random` does. Please do not touch this code
*   The output of the program should be:
    *   The number, followed by
        *   if the number is greater than 0: `is positive`
        *   if the number is 0: `is zero`
        *   if the number is less than 0: `is negative`
    *   followed by a new line
```
    carrie@ubuntu:~/0x01/0-positive_or_negative$ ls
    0-positive_or_negative.cs  0-positive_or_negative.csproj  bin  obj
    carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
    3 is positive
    carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
    6 is positive
    carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
    -1 is negative
    carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
    -6 is negative
    carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
    -7 is negative
    carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
    0 is zero
    carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
    6 is positive
    carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
    -2 is negative
    carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
    -8 is negative
    carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
    8 is positive
    carrie@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
    -10 is negative
    carrie@ubuntu:~/0x01/0-positive_or_negative$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x01-csharp-ifelse_loops_methods`
*   File: `0-positive_or_negative/, 0-positive_or_negative/0-positive_or_negative.csproj, 0-positive_or_negative/0-positive_or_negative.cs`


#### Students who are done with "1. The last digit"

#### 1\. The last digit mandatory



This program will assign a random signed number to the variable `number` each time it is executed. Complete the
```
using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
	// YOUR CODE GOES HERE. PLEASE REMOVE THIS LINE
    }
}
```
in order to print whether the number stored in the variable `number` is positive or negative.

*   The variable `number` will store a different value every time you will run this program
*   You don’t have to understand what `Random` does. Please do not touch this code
*   The output of the program should be:
    *   The string `The last digit of`, followed by
    *   the `number`, followed by
    *   the string `is`, followed by
        *   if the number is greater than 5: the string `and is greater than 5`
        *   if the number is 0: the string `and is 0`
        *   if the number is less than 6 and not 0: the string `and is less than 6 and not 0`
    *   followed by a new line
```
    carrie@ubuntu:~/0x01/1-last_digit$ ls
    1-last_digit.cs  1-last_digit.csproj  bin  obj
    carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
    The last digit of 8903 is 3 and is less than 6 and not 0
    carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
    The last digit of -6117 is -7 and is less than 6 and not 0
    carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
    The last digit of 2790 is 0 and is 0
    carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
    The last digit of 7363 is 3 and is less than 6 and not 0
    carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
    The last digit of 7590 is 0 and is 0
    carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
    The last digit of -3435 is -5 and is less than 6 and not 0
    carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
    The last digit of 6661 is 1 and is less than 6 and not 0
    carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
    The last digit of -365 is -5 and is less than 6 and not 0
    carrie@ubuntu:~/0x01/1-last_digit$ dotnet run
    The last digit of 619 is 9 and is greater than 5
    carrie@ubuntu:~/0x01/1-last_digit$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x01-csharp-ifelse_loops_methods`
*   File: `1-last_digit/, 1-last_digit/1-last_digit.csproj, 1-last_digit/1-last_digit.cs`

#### Students who are done with "2. I sometimes suffer from insomnia. And when I can't fall asleep, I play what I call the alphabet game"

#### 2\. I sometimes suffer from insomnia. And when I can't fall asleep, I play what I call the alphabet game mandatory



Write a program that prints the alphabet, in lowercase, not followed by a new line.

*   You can only use `Console.Write` once
*   You can only use one loop in your code
```
    carrie@ubuntu:0x01/2-print_alphabet$ ls
    2-print_alphabet.cs  2-print_alphabet.csproj  bin  obj
    carrie@ubuntu:0x01/2-print_alphabet$ dotnet run
    abcdefghijklmnopqrstuvwxyzcarrie@ubuntu:0x01/2-print_alphabet$ 
``` 

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x01-csharp-ifelse_loops_methods`
*   File: `2-print_alphabet/, 2-print_alphabet/2-print_alphabet.csproj, 2-print_alphabet/2-print_alphabet.cs`


#### Students who are done with "3. When I was having that alphabet soup, I never thought that it would pay off"

#### 3\. When I was having that alphabet soup, I never thought that it would pay off mandatory



Write a program that prints the alphabet, in lowercase, not followed by a new line.

*   Print all the letters except `q` and `e`
*   You can only use `Console.Write` once
*   You can only use one loop in your code
```
    carrie@ubuntu:0x01/3-print_alphabt$ ls
    3-print_alphabt.cs  3-print_alphabt.csproj  bin  obj
    carrie@ubuntu:0x01/3-print_alphabt$ dotnet run
    abcdfghijklmnoprstuvwxyzcarrie@ubuntu:0x01/3-print_alphabt$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x01-csharp-ifelse_loops_methods`
*   File: `3-print_alphabt/, 3-print_alphabt/3-print_alphabt.csproj, 3-print_alphabt/3-print_alphabt.cs`



#### Students who are done with "4. Hexadecimal printing"

#### 4\. Hexadecimal printing mandatory



Write a program that prints all numbers from 0 to 98 in decimal and in hexadecimal (as in the following example)

*   You can only use `Console.Write` once
*   You can only use one loop in your code
```
    carrie@ubuntu:0x01/4-print_hexa$ ls
    4-print_hexa.cs  4-print_hexa.csproj  bin  obj
    carrie@ubuntu:0x01/4-print_hexa$ dotnet run
    0 = 0x0
    1 = 0x1
    2 = 0x2
    3 = 0x3
    4 = 0x4
    5 = 0x5
    6 = 0x6
    7 = 0x7
    8 = 0x8
    9 = 0x9
    10 = 0xa
    11 = 0xb
    12 = 0xc
    13 = 0xd
    14 = 0xe
    15 = 0xf
    16 = 0x10
    17 = 0x11
    18 = 0x12
    ...
    96 = 0x60
    97 = 0x61
    98 = 0x62
    carrie@ubuntu:0x01/4-print_hexa$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x01-csharp-ifelse_loops_methods`
*   File: `4-print_hexa/, 4-print_hexa/4-print_hexa.csproj, 4-print_hexa/4-print_hexa.cs`


#### Students who are done with "5. 00...99"

#### 5\. 00...99 mandatory



Write a program that prints numbers from `0` to `99`.

*   Numbers must be separated by `,`, followed by a space
*   Numbers should be printed in ascending order, with two digits
*   The last number should be followed by a new line
*   You can only use `Console.Write` no more than twice
*   You can only use one loop in your code
```
    carrie@ubuntu:0x01/5-print_comb$ ls
    5-print_comb.cs  5-print_comb.csproj  bin  obj
    carrie@ubuntu:0x01/5-print_comb$ dotnet run
    00, 01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99
    carrie@ubuntu:0x01/5-print_comb$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x01-csharp-ifelse_loops_methods`
*   File: `5-print_comb/, 5-print_comb/5-print_comb.csproj, 5-print_comb/5-print_comb.cs`


#### Students who are done with "6. Inventing is a combination of brains and materials. The more brains you use, the less material you need"

#### 6\. Inventing is a combination of brains and materials. The more brains you use, the less material you need mandatory



Write a program that prints all possible different combinations of two digits.

*   Numbers must be separated by `,`, followed by a space
*   The two digits must be different
*   01 and 10 are considered the same combination of the two digits 0 and 1
*   Print only the smallest combination of two digits
*   Numbers should be printed in ascending order, with two digits
*   The last number should be followed by a new line
*   You can only use `Console.Write` and `Console.WriteLine` no more than three times total
*   You can only use no more than 2 loops in your code
```
    carrie@ubuntu:0x01/6-print_comb2$ ls
    6-print_comb2.cs  6-print_comb2.csproj  bin  obj
    carrie@ubuntu:0x01/6-print_comb2$ dotnet run
    01, 02, 03, 04, 05, 06, 07, 08, 09, 12, 13, 14, 15, 16, 17, 18, 19, 23, 24, 25, 26, 27, 28, 29, 34, 35, 36, 37, 38, 39, 45, 46, 47, 48, 49, 56, 57, 58, 59, 67, 68, 69, 78, 79, 89
    carrie@ubuntu:0x01/6-print_comb2$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x01-csharp-ifelse_loops_methods`
*   File: `6-print_comb2/, 6-print_comb2/6-print_comb2.csproj, 6-print_comb2/6-print_comb2.cs`



#### Students who are done with "7. islower"

#### 7\. islower mandatory



Write a method that checks for lowercase character.

*   Class Name: `class Character`
*   Prototype: `public static bool IsLower(char c)`
*   Returns `True` if `c` is lowercase
*   Returns `False` otherwise
*   You are not allowed to use `Char.IsLower()` or `Char.IsUpper()`
```
    carrie@ubuntu:~/0x01/7-islower$ cat 7-main.cs 
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = { 'a', 'A', 'Q', 'h', '9', 'B', 'g'};
            int i;
    
            for (i = 0; i < letters.Length; i++)
            {
                if(Character.IsLower(letters[i]))
                    Console.WriteLine("{0} is lowercase", letters[i]);
                else
                    Console.WriteLine("{0} is uppercase", letters[i]);
            }
        }
    }
    carrie@ubuntu:~/0x01/7-islower$  
```    
```
    carrie@ubuntu:~/0x01/7-islower$ ls
    7-islower.cs  7-islower.csproj  7-main.cs  bin  obj
    carrie@ubuntu:~/0x01/7-islower$ dotnet run
    a is lowercase
    A is uppercase
    Q is uppercase
    h is lowercase
    9 is uppercase
    B is uppercase
    g is lowercase
    carrie@ubuntu:~/0x01/7-islower$
    
```
**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x01-csharp-ifelse_loops_methods`
*   File: `7-islower/, 7-islower/7-islower.csproj, 7-islower/7-islower.cs`



#### Students who are done with "8. There are only 3 colors, 10 digits, and 7 notes; its what we do with them that's important"

#### 8\. There are only 3 colors, 10 digits, and 7 notes; its what we do with them that's important mandatory



Write a method that prints the last digit of a number.

*   Class Name: `class Number`
*   Prototype: `public static int PrintLastDigit(int number)`
*   Returns the value of the last digit
```
    carrie@ubuntu:0x01/8-print_last_digit$ cat 8-main.cs 
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            int r;
    
            Number.PrintLastDigit(98);
            Number.PrintLastDigit(0);
            r = Number.PrintLastDigit(-1024);
            Console.WriteLine(r);
        }
    }
    carrie@ubuntu:0x01/8-print_last_digit$
```    
```
    carrie@ubuntu:0x01/8-print_last_digit$ ls
    8-main.cs  8-print_last_digit.cs  8-print_last_digit.csproj  bin  obj
    carrie@ubuntu:0x01/8-print_last_digit$ dotnet run
    8044
    carrie@ubuntu:0x01/8-print_last_digit$
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x01-csharp-ifelse_loops_methods`
*   File: `8-print_last_digit/, 8-print_last_digit/8-print_last_digit.csproj, 8-print_last_digit/8-print_last_digit.cs`


#### Students who are done with "9. a + b"

#### 9\. a + b mandatory



Write a method that adds two integers and returns the result.

*   Class Name: `class Number`
*   Prototype: `public static int Add(int a, int b)`
*   Returns the value of a + b
```
    carrie@ubuntu:0x01/9-add$ cat 9-main.cs 
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", Number.Add(1, 2));
            Console.WriteLine("{0}", Number.Add(98, 0));
            Console.WriteLine("{0}", Number.Add(100, -2));
        }
    }
    carrie@ubuntu:0x01/9-add$ 
```    
```
    carrie@ubuntu:0x01/9-add$ ls
    9-add.cs  9-add.csproj  9-main.cs  bin  obj
    carrie@ubuntu:0x01/9-add$ dotnet run
    3
    98
    98
    carrie@ubuntu:0x01/9-add$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x01-csharp-ifelse_loops_methods`
*   File: `9-add/, 9-add/9-add.csproj, 9-add/9-add.cs`


#### Students who are done with "10. The shortest distance between two points is a straight line"

#### 10\. The shortest distance between two points is a straight line mandatory



Write a method that draws a straight line in the terminal.

*   Class Name: `class Line`
*   Prototype: `public static void PrintLine(int length)`
*   Where `length` is the number of times the character `_` should be printed
*   The line should end with a new line
*   If `length` is `0` or less, the function should only print a new line
```
    carrie@ubuntu:0x01/10-print_line$ cat 10-main.cs 
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Line.PrintLine(3);
            Line.PrintLine(0);
            Line.PrintLine(12);
            Line.PrintLine(-98);
        }
    }
```    
```
    carrie@ubuntu:0x01/10-print_line$ 
    carrie@ubuntu:0x01/10-print_line$ ls
    10-main.cs  10-print_line.cs  10-print_line.csproj  bin  obj
    carrie@ubuntu:0x01/10-print_line$ dotnet run | cat -e
    ___$
    $
    ____________$
    $
    carrie@ubuntu:0x01/10-print_line$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x01-csharp-ifelse_loops_methods`
*   File: `10-print_line/, 10-print_line/10-print_line.csproj, 10-print_line/10-print_line.cs`


#### Students who are done with "11. I feel like I am diagonally parked in a parallel universe"

#### 11\. I feel like I am diagonally parked in a parallel universe mandatory



Write a method that draws a diagonal line in the terminal.

*   Class Name: `class Line`
*   Prototype: `public static void PrintDiagonal(int length)`
*   Where `length` is the number of times the character `\` should be printed
*   The line should end with a new line
*   If `length` is `0` or less, the function should only print a new line
```
    carrie@ubuntu:0x01/11-print_diagonal$ cat 11-main.cs 
    using System;
    
    class ExecutePrintDiagonal
    {
        static void Main(string[] args)
        {
            Line.PrintDiagonal(3);
            Line.PrintDiagonal(0);
            Line.PrintDiagonal(12);
            Line.PrintDiagonal(-98);
        }
    }
```    
```
    carrie@ubuntu:0x01/11-print_diagonal$ ls
    11-main.cs  11-print_diagonal.cs  11-print_diagonal.csproj  bin  obj
    carrie@ubuntu:0x01/11-print_diagonal$ dotnet run | cat -e
    \$
     \$
      \$
    $
    $
    \$
     \$
      \$
       \$
        \$
         \$
          \$
           \$
            \$
             \$
              \$
               \$
    $
    $
    carrie@ubuntu:0x01/11-print_diagonal$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x01-csharp-ifelse_loops_methods`
*   File: `11-print_diagonal/, 11-print_diagonal/11-print_diagonal.csproj, 11-print_diagonal/11-print_diagonal.cs`


#### Students who are done with "12. Fizz Buzz"

#### 12\. Fizz Buzz mandatory



Write a program that prints the numbers from 1 to 100 separated by a space.

*   For multiples of three print `Fizz` instead of the number and for multiples of five print `Buzz`.
*   For numbers which are multiples of both three and five print `FizzBuzz`.
*   Each element should be followed by a space
*   The last element should be followed by a new line
```
    carrie@ubuntu:0x01/12-fizzbuzz$ ls
    12-fizzbuzz.cs  12-fizzbuzz.csproj  bin  obj
    carrie@ubuntu:0x01/12-fizzbuzz$ dotnet run | cat -e
    1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz$
    carrie@ubuntu:0x01/12-fizzbuzz$ 
```    

**Repo:**

*   GitHub repository: `holbertonschool-csharp`
*   Directory: `0x01-csharp-ifelse_loops_methods`
*   File: `12-fizzbuzz/, 12-fizzbuzz/12-fizzbuzz.csproj, 12-fizzbuzz/12-fizzbuzz.cs`

