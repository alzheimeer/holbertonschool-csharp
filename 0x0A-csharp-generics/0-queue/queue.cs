using System;

///<summary>Class for que opperations</summary>
class Queue<T>
{
	///<summary>Check if its a queue type</summary>
	///<return>returns a Queue type</return>
	public Type CheckType()
	{
		return typeof(T);
	}
}