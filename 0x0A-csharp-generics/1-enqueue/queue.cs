using System;

///<summary>Class for que opperations</summary>
class Queue<T>
{
    public Node head;
    public Node tail;   
    public int count;
    
    ///<summary>Check if its a queue type</summary>
	///<return>returns a Queue type</return>
	public Type CheckType()
	{
		return typeof(T);
	}

    
    ///<summary>public class called Node with two properties</summary>
    public class Node
    {
        private T value = default(T);
        public Node next = null;
        // A constructor with one argument.
        public Node(T input)
        {
            value = input;
        }
    }
   
    
    
    ///<summary>Add new node at the end</summary>
    public void Enqueue(T value)
    {
        Node newnode = new Node(value);
		if (head == null)
		{
			head = newnode;
			tail = newnode;
		}
		else
		{
			tail.next = newnode;
			tail = newnode;
		}
		count++;
    }
    ///<summary>return count the nodes</summary>
    public int Count()
    {
        return count;
    }



}
