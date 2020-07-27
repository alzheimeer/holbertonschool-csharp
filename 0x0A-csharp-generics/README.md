# 0x0A. C# - Generics

Specializations - AR/VR ― C#

## Background Context

##### In this project, you will implement a Queue in C# with a singly linked list and generics. You are not allowed

##### to use System.Collections or System.Collections.Generic for this project.

<article id="description" class="gap formatted-content">
<h2>Background Context</h2><p>In this project, you will implement a Queue in C# with a singly linked list and generics. You are <strong>not</strong> allowed to use <code>System.Collections</code> or <code>System.Collections.Generic</code> for this project.</p><h2>Resources</h2><p><strong>Read or watch</strong>:</p>
<ul>
<li><a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/" title="Generics (C# Programming Guide)" target="_blank">Generics (C# Programming Guide)</a> (<em>Read sections “Introduction to Generics” up to and including “Generics and Arrays”</em>)</li>
<li><a href="https://docs.microsoft.com/en-us/dotnet/standard/generics/" title="Generics in .NET" target="_blank">Generics in .NET</a>¨NBSP;</li>
<li><a href="https://www.youtube.com/watch?v=gyal6TbgmSU" title="C# Generics Tutorial: Whats and Whys" target="_blank">C# Generics Tutorial: Whats and Whys</a></li>
<li><a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers" title="Access Modifiers (C# Programming Guide)" target="_blank">Access Modifiers (C# Programming Guide)</a></li>
<li><a href="https://docs.microsoft.com/en-us/dotnet/standard/generics/covariance-and-contravariance" title="Covariance and Contravariance in Generics" target="_blank">Covariance and Contravariance in Generics</a></li>
<li><a href="https://codepureandsimple.com/covariance-and-contravariance-with-c-410fc4102a02" title="Covariance and Contravariance with C#" target="_blank">Covariance and Contravariance with C#</a></li></ul>



<li>What are generics and what are their purpose</li>
<li>What common generic classes and interfaces are provided in the .NET class library</li>
<li>When and how to create generic classes</li>
<li>When and how to create generic methods</li>
<li>How access modifiers affect a class and its members</li>
<li>What is the <code>default(T)</code> expression used for</li>
<li>What is covariance and contravariance</li></ul></article>




#### Question #1

<!-- Quiz question tags -->

<!-- Quiz question Body -->

It’s preferable to create your own custom generic types instead of using the generics provided by the .NET framework.

<!-- Quiz question Answers -->

- <input type="checkbox" data-quiz-question-id="798" data-quiz-answer-id="1541459729623" disabled="">

    True

- <input type="checkbox" data-quiz-question-id="798" data-quiz-answer-id="1541459732305" disabled="" checked="">

    False


<!-- -->

<!-- Quiz question Tips -->

<div class="quiz_question_item_container" data-role="quiz_question799" data-position="3"><div class=" clearfix" id="quiz_question-799"><h4 class="quiz_question">Question #2</h4><!-- Quiz question tags --><!-- Quiz question Body --><p>How is the type of an item represented in a generic context?</p><!-- Quiz question Answers --><ul class="quiz_question_answers" data-question-id="799"><li class=""><input type="checkbox" data-quiz-question-id="799" data-quiz-answer-id="1541459740057" disabled=""><p>With the parameter <code>Type</code></p></li><li class=""><input type="checkbox" data-quiz-question-id="799" data-quiz-answer-id="1541459751163" disabled=""><p>With the namespace <code>System.Collections.Generic</code></p></li><li class=""><input type="checkbox" data-quiz-question-id="799" data-quiz-answer-id="1541459752314" disabled="" checked=""><p>With the parameter <code>T</code></p></li></ul><!-- Quiz question Tips --></div></div>

<div class="quiz_question_item_container" data-role="quiz_question800" data-position="4"><div class=" clearfix" id="quiz_question-800"><h4 class="quiz_question">Question #3</h4><!-- Quiz question tags --><!-- Quiz question Body --><p>What constraint requires the type argument to be a reference type?</p><!-- Quiz question Answers --><ul class="quiz_question_answers" data-question-id="800"><li class=""><input type="checkbox" data-quiz-question-id="800" data-quiz-answer-id="1541459770024" disabled=""><p><code>where T : struct</code></p></li><li class=""><input type="checkbox" data-quiz-question-id="800" data-quiz-answer-id="1541459779539" disabled="" checked=""><p><code>where T : class</code></p></li><li class=""><input type="checkbox" data-quiz-question-id="800" data-quiz-answer-id="1541459785407" disabled=""><p><code>where T : ref</code></p></li></ul><!-- Quiz question Tips --></div></div>

<div class="quiz_question_item_container" data-role="quiz_question801" data-position="5"><div class=" clearfix" id="quiz_question-801"><h4 class="quiz_question">Question #4</h4><!-- Quiz question tags --><!-- Quiz question Body --><p>What constraint requires the type argument to be a value type?</p><!-- Quiz question Answers --><ul class="quiz_question_answers" data-question-id="801"><li class=""><input type="checkbox" data-quiz-question-id="801" data-quiz-answer-id="1541459832378" disabled="" checked=""><p><code>where T : struct</code></p></li><li class=""><input type="checkbox" data-quiz-question-id="801" data-quiz-answer-id="1541459833917" disabled=""><p><code>where T : class</code></p></li><li class=""><input type="checkbox" data-quiz-question-id="801" data-quiz-answer-id="1541459835406" disabled=""><p><code>where T : ref</code></p></li></ul><!-- Quiz question Tips --></div></div>

<div class="quiz_question_item_container" data-role="quiz_question802" data-position="6"><div class=" clearfix" id="quiz_question-802"><h4 class="quiz_question">Question #5</h4><!-- Quiz question tags --><!-- Quiz question Body --><p>Which of the following correctly specifies that a generic type must be or inherit from class <code>BaseClass</code>?</p><!-- Quiz question Answers --><ul class="quiz_question_answers" data-question-id="802"><li class=""><input type="checkbox" data-quiz-question-id="802" data-quiz-answer-id="1541459857414" disabled=""><p><code>public class MyList&lt;BaseClass&gt;</code></p></li><li class=""><input type="checkbox" data-quiz-question-id="802" data-quiz-answer-id="1541459858941" disabled=""><p><code>public class MyList&lt;BaseClass&gt; where T : class</code></p></li><li class=""><input type="checkbox" data-quiz-question-id="802" data-quiz-answer-id="1541459860477" disabled=""><p><code>public class MyList&lt;T&gt; where T : class</code></p></li><li class=""><input type="checkbox" data-quiz-question-id="802" data-quiz-answer-id="1541459861494" disabled="" checked=""><p><code>public class MyList&lt;T&gt; where T : BaseClass</code></p></li></ul><!-- Quiz question Tips --></div></div>

<div class="quiz_question_item_container" data-role="quiz_question885" data-position="7"><div class=" clearfix" id="quiz_question-885"><h4 class="quiz_question">Question #6</h4><!-- Quiz question tags --><!-- Quiz question Body --><p>Contravariance enables you to use a more derived type than originally specified, while covariance enables you to use a less derived type than originally specified.</p><!-- Quiz question Answers --><ul class="quiz_question_answers" data-question-id="885"><li class=""><input type="checkbox" data-quiz-question-id="885" data-quiz-answer-id="1561425807703" disabled=""><p>True</p></li><li class=""><input type="checkbox" data-quiz-question-id="885" data-quiz-answer-id="1561425808883" disabled="" checked=""><p>False</p></li></ul><!-- Quiz question Tips --></div></div>

####  0\. Queue <span class="alert alert-warning mandatory-optional"> mandatory </span>



<!-- Progress vs Score -->

<!-- Task Body -->

Create a new class called `Queue&lt;T&gt;`.

- `Queue&lt;T&gt;` should not inherit from other classes or interfaces.
- Within `Queue&lt;T&gt;`, create a new method `CheckType()` that returns the Queue’s type.
- You are **not** allowed to use `System.Collections` or `System.Collections.Generic` for this project.

<!-- -->


```
carrie@ubuntu:~/0x0A-csharp-generics/0-queue$ cat 0-main.cs
using System;
```
```
class Program
{
static void Main(string[] args)
{
Queue<string> myStrQ = new Queue<string>();
Queue<object> myObjQ = new Queue<object>();
```
```
Console.WriteLine($"{nameof(myStrQ)} Queue Type: " + myStrQ.CheckType());
Console.WriteLine($"{nameof(myObjQ)} Queue Type: " + myObjQ.CheckType());
}
}
carrie@ubuntu:~/0x0A-csharp-generics/0-queue$
```
```
carrie@ubuntu:~/0x0A-csharp-generics/0-queue$ dotnet run
myStrQ Queue Type: System.String
myObjQ Queue Type: System.Object
carrie@ubuntu:~/0x0A-csharp-generics/0-queue$
```
##### Repo:

##### GitHub repository: holbertonschool-csharp

##### Directory: 0x0A-csharp-generics

##### File: 0-queue/, 0-queue/0-queue.csproj, 0-queue/queue.cs

####  1\. Enqueue <span class="alert alert-warning mandatory-optional"> mandatory </span>



<!-- Progress vs Score -->

<!-- Task Body -->

Based on `0-queue`, within `Queue&lt;T&gt;`, create a public class called `Node` with the following properties:

- `value`: can be of any type, set its initial value to `null`
- `next`: must be an object of type `Node`, set its initial value to `null`
- Define a constructor that takes a `value` for a new `Node` as its only parameter and sets it

<!-- -->

Within `Queue&lt;T&gt;`, add the following properties:

- `head`: must be an object of type `Node`
- `tail`: must be an object of type `Node`
- `count`: type `int`

<!-- -->

Add a new method `Enqueue()` to the class `Queue` that creates a new `Node` and adds it to the end of the queue.

- If the queue is empty, the method should make the new node the head of the queue
- `count` should update every time a new node is added

<!-- -->

Add a new method `Count()` to the class that returns the number of nodes in the Queue.

```
carrie@ubuntu:~/0x0A-csharp-generics/1-enqueue$ cat 0-main.cs
using System;
```
```
class Program
{
static void Main(string[] args)
{
Queue<string> myStrQ = new Queue<string>();
```
```
myStrQ.Enqueue("Hello");
Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());
```
```
myStrQ.Enqueue("World");
Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());
```
```
Console.WriteLine("----------");
```
```
Queue<float> myFloatQ = new Queue<float>();
```
```
myFloatQ.Enqueue(4.2f);
myFloatQ.Enqueue(4.2f);
myFloatQ.Enqueue(4.2f);
Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());
```
```
myFloatQ.Enqueue(-9.8f);
Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());
}
}
carrie@ubuntu:~/0x0A-csharp-generics/1-enqueue$
```
```
carrie@ubuntu:~/0x0A-csharp-generics/1-enqueue$ dotnet run
Number of nodes in queue: 1
Number of nodes in queue: 2
----------
Number of nodes in queue: 3
Number of nodes in queue: 4
carrie@ubuntu:~/0x0A-csharp-generics/1-enqueue$
```
##### Repo:

##### GitHub repository: holbertonschool-csharp

##### Directory: 0x0A-csharp-generics

##### File: 1-enqueue/, 1-enqueue/1-enqueue.csproj, 1-enqueue/queue.cs



####  2\. Dequeue <span class="alert alert-warning mandatory-optional"> mandatory </span>



<!-- Progress vs Score -->

<!-- Task Body -->

Based on `1-enqueue`, add a new method `Dequeue()` to the class `Queue&lt;T&gt;` that removes the first node in the queue and returns its value.

- If the queue is empty, the method should write `Queue is empty` to the console and return the default value of the parameter’s type

<!-- -->


```
carrie@ubuntu:~/0x0A-csharp-generics/2-dequeue$ cat 0-main.cs
using System;
```
```
class Program
{
static void Main(string[] args)
{
Queue<int> myIntQ = new Queue<int>();
```
```
myIntQ.Enqueue(100);
myIntQ.Enqueue(101);
Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());
```
```
Console.WriteLine("First value: " + myIntQ.Dequeue());
Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());
```
```
Console.WriteLine("----------");
```
```
Queue<float> myFloatQ = new Queue<float>();
```
```
myFloatQ.Enqueue(9.8f);
Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());
```
```
Console.WriteLine("First value: " + myFloatQ.Dequeue());
```
```
Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());
```
```
Console.WriteLine("First value: " + myFloatQ.Dequeue());
}
}
carrie@ubuntu:~/0x0A-csharp-generics/2-dequeue$
```
```
carrie@ubuntu:~/0x0A-csharp-generics/2-dequeue$ dotnet run
Number of nodes in queue: 2
First value: 100
Number of nodes in queue: 1
----------
Number of nodes in queue: 1
First value: 9.
Number of nodes in queue: 0
Queue is empty
First value: 0
carrie@ubuntu:~/0x0A-csharp-generics/2-dequeue$
```
##### Repo:



##### GitHub repository: holbertonschool-csharp

##### Directory: 0x0A-csharp-generics

##### File: 2-dequeue/, 2-dequeue/2-dequeue.csproj, 2-dequeue/queue.cs

####  3\. Peek <span class="alert alert-warning mandatory-optional"> mandatory </span>



<!-- Progress vs Score -->

<!-- Task Body -->

Based on `2-dequeue`, add a new method `Peek()` to the class `Queue&lt;T&gt;` that returns the value of the first node of the queue without removing the node.

- If the queue is empty, the method should write `Queue is empty` to the console and return the default value of the parameter’s type

<!-- -->



```
carrie@ubuntu:~/0x0A-csharp-generics/3-peek$ cat 0-main.cs
using System;
```
```
class Program
{
static void Main(string[] args)
{
Queue<int> myIntQ = new Queue<int>();
```
```
myIntQ.Enqueue(100);
myIntQ.Enqueue(101);
myIntQ.Enqueue(102);
```
```
Console.WriteLine("First value: " + myIntQ.Peek());
Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());
```
```
Console.WriteLine("----------");
```
```
Queue<char> myCharQ = new Queue<char>();
Console.WriteLine("First value: " + myCharQ.Peek());
}
}
carrie@ubuntu:~/0x0A-csharp-generics/3-peek$
```
```
carrie@ubuntu:~/0x0A-csharp-generics/3-peek$
First value: 100
Number of nodes in queue: 3
----------
Queue is empty
First value:
carrie@ubuntu:~/0x0A-csharp-generics/3-peek$
```
##### Repo:

##### GitHub repository: holbertonschool-csharp

##### Directory: 0x0A-csharp-generics

##### File: 3-peek/, 3-peek/3-peek.csproj, 3-peek/queue.cs



####  4\. Print <span class="alert alert-warning mandatory-optional"> mandatory </span>



<!-- Progress vs Score -->

<!-- Task Body -->

Based on `3-peek`, add a new method `Print()` to the class `Queue<T>` that prints the queue, starting from the head.

- If the queue is empty, the method should write `Queue is empty` to the console

<!-- -->



```
carrie@ubuntu:~/0x0A-csharp-generics/4-print$ cat 0-main.cs
using System;
```
```
class Program
{
static void Main(string[] args)
{
Queue<string> myStrQ = new Queue<string>();
```
```
myStrQ.Enqueue("hello");
myStrQ.Enqueue("holberton");
myStrQ.Enqueue("school");
```
```
myStrQ.Print();
```
```
Console.WriteLine("----------");
```
```
Queue<int> myIntQ = new Queue<int>();
myIntQ.Print();
}
}
carrie@ubuntu:~/0x0A-csharp-generics/4-print$
```
```
carrie@ubuntu:~/0x0A-csharp-generics/4-print$
hello
holberton
school
----------
Queue is empty
carrie@ubuntu:~/0x0A-csharp-generics/4-print$
```
##### Repo:

##### GitHub repository: holbertonschool-csharp

##### Directory: 0x0A-csharp-generics

##### File: 4-print/, 4-print/4-print.csproj, 4-print/queue.cs

####  5\. Concatenate <span class="alert alert-warning mandatory-optional"> mandatory </span>



<!-- Progress vs Score -->

<!-- Task Body -->

Based on `4-print`, create a method `Concatenate()` that concatenates all values in the queue only if the queue is of type `String` or `Char`.

- If queue is empty, print `Queue is empty` and return `null`
- If the queue is not of type `String` or `Char`, print `Concatenate() is for a queue of Strings or Chars only.` to the console and return `null`

<!-- -->



```
carrie@ubuntu:~/0x0A-csharp-generics/5-concatenate$ cat 0-main.cs
using System;
```
```
class Program
{
static void Main(string[] args)
{
Queue<string> myStrQ = new Queue<string>();
```
```
myStrQ.Enqueue("hello");
myStrQ.Enqueue("holberton");
myStrQ.Enqueue("school");
```
```
Console.WriteLine(myStrQ.Concatenate());
```
```
Console.WriteLine("----------");
```
```
Queue<int> myIntQ = new Queue<int>();
myIntQ.Concatenate();
```
```
Console.WriteLine("----------");
```
```
Queue<char> myCharQ = new Queue<char>();
myCharQ.Enqueue('a');
myCharQ.Enqueue('b');
myCharQ.Enqueue('c');
Console.WriteLine(myCharQ.Concatenate());
}
}
carrie@ubuntu:~/0x0A-csharp-generics/5-concatenate$
```
```
carrie@ubuntu:~/0x0A-csharp-generics/5-concatenate$
hello holberton school
----------
Queue is empty
----------
abc
carrie@ubuntu:~/0x0A-csharp-generics/5-concatenate$
```
##### Repo:

##### GitHub repository: holbertonschool-csharp

##### Directory: 0x0A-csharp-generics

##### File: 5-concatenate/, 5-concatenate/5-concatenate.csproj, 5-concatenate/queue.cs