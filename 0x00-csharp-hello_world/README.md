# 0x00. C# - Hello, World - 04-13-2020

<img alt="C#" src="../logo.jpg" width=80% height=80%>

**What I learned from this project**

* What is the meaning behind the name C#?
C++++
Inspired from musical notation where a sharp indicates that the written note should be made a half-step higher in pitch

*	Who is the lead architect of the development team of C#?
Anders Hejlseberg

*	What is .NET?
a software framework developed by Microsoft

*	What is the difference between C# and .NET?
C# is a programming language, . NET is the framework that the language is built on. 
C# is a strong Object Oriented programming language that is mostly built on the . NET framework.

*	How to use VSCode and the integrated terminal to initialize, build, and run C# projects
Initialize: dotnet new console
build: dotnet build
run: dotnet run

*	How to print text and variables using Console.Write
Console.write("Date: {0:d}:\n   Temperature at {1:t}: {2}\n   Temperature at {3:t}: {4}\n", dateRecorded, startTime, temperature1, startTime.Add(interval), temperature2);

*	How to print text and variables using Console.WriteLine
Console.WriteLine("{0} {1} {2}", number1, number2, number3);

*	What is Intermediate Language (IL) code?
a language used by .NET Framework to generate machine-independent code
a language with a purpose similar to Java bytecode

*	What is CLR?
Common Language Runtime


## Exercises

[0. Initialize new project](./0-initialize_new_project.sh)
```
Write a Bash script that initializes a new C# project inside a folder titled 0-new_project.

* Use the command dotnet
```
[1. Build new project ](./1-build_new_project.sh)
```
Write a Bash script that initializes and builds a new C# project inside a folder titled 1-new_project.

* Use the command dotnet
```
[2. Run new project](./2-run_new_project.sh)
```
Write a Bash script that initializes, builds, and runs a new C# project from a folder titled 2-new_project.

* Use the command dotnet
```
[3. Hello, WriteLine ](./3-writeline)
```
Write a C# script that prints exactly "Programming is like building a multilingual puzzle followed by a new line.

* Use the method Console.WriteLine
```
[4. Print integer](./4-print_integer)
```
Complete this source code in order to print the integer stored in the variable number, followed by Mission Street followed by a new line.

* You can find the source code [here](https://intranet.hbtn.io/rltoken/euxMhFdEF0-XZCLtdqne4Q)
* Your code should be exactly 10 lines long
* The output of the script should be:
  * the number, followed by Mission Street
  * followed by a new line
```
[5. Print float](./5-print_float)
```
Complete this source code in order to print the float stored in the variable number with a precision of 2 digits.

* You can find the source code [here](https://intranet.hbtn.io/rltoken/kuytn76s-qptXICqj2Vmmg)
* Your script should be exactly 10 lines long
* The output of the script should be:
  * Float: followed by the number with only 2 digits
  * followed by a new line
```
[6. Print string](./6-print_string)
```
Complete this source code in order to print a string stored in the variable str 3 times, followed by its first 9 characters.

* You can find the source code [here](https://intranet.hbtn.io/rltoken/BsLlMCzRgrGoeGqCGX3LWw)
* The output of the script should be:
  * the value of str 3 times
  * followed by a new line
  * followed by the first 9 characters of str
  * followed by a new line
* You are not allowed to use any loops or conditional statement
```
[7. Play with strings ](./7-concat)
```
Complete this source code to print Welcome to Holberton School!

* You can find the source code [here](https://intranet.hbtn.io/rltoken/legokuhnEkmHGP5-JkQV9w)
* Your code should be exactly 12 lines long
* You are not allowed to use any loops or conditional statement
* You have to use the variables str1 and str2 in your new line of code
```
[8. Print variables](./8-print_variables)
```
Complete this source code in order to print the given variables as 972 Mission Street.

* You can find the source code [here](https://intranet.hbtn.io/rltoken/c5U7giCio60Do2H4XU5YMg)
* Your code should be exactly 12 lines long
* You are not allowed to create new variables
* You are not allowed to edit existing variables
* The output of the script should be:
  * 972 Mission Street
  * followed by a new line
```
[9. Print specifiers ](./9-print_specifiers)
```
Complete this source code in order to print the given variables as in the result shown.

* You can find the source code [here](https://intranet.hbtn.io/rltoken/foEqLuZu644GyfX37MNTSw)
* Your code should be exactly 12 lines long
* You are not allowed to create new variables
* The output of the script should be:
  * Percent: 75.53% tip
  * followed by a new line
  * followed by Currency: $98,765.43
  * followed by a new line
```
[10. Copy - Cut - Paste ](./10-copy_cut_paste)
```
Complete this source code.

* You can find the source code [here](https://intranet.hbtn.io/rltoken/WOeBK1z0kP2-UUYhVmVEhQ)
* Your code should be exactly 15 lines long
* You are not allowed to use any loops or conditional statements
* word_first_3 should contain the first 3 letters of the variable word
* word_last_2 should contain the last 2 letters of the variable word
* middle_word should contain the value of the variable word without the first and last letters
```
[11. Create a new sentence](./11-concat_edges)
```
Complete this source code to print object-oriented programming in C# followed by a new line.

* You can find the source code [here](https://intranet.hbtn.io/rltoken/jATFMnzdEgJstHhRISMf7A)
* Your code should be exactly 11 lines long
* You are not allowed to use any loops or conditional statements
* You are not allowed to create new variables
* You are not allowed to use string literals
```
[12. Hello, Error](./100-hello_error)
```
Write a Python script that prints exactly and that piece of art is useful - Dora Korpar, 2015-10-19 followed by a new line.

* Your script should print to stderr
* Your script should exit with the status code 1
```