using System;
using System.Collections;

internal class Program
{
	public class MinStack
	{
		Stack stack;
		int minElement;


		public MinStack()
		{
			stack = new Stack();
			minElement = Int32.MaxValue;

		}

		public void Push(int val)
		{

			if (val <= minElement)
			{
				stack.Push(minElement);
				minElement = val;
			}

			stack.Push(val);

		}

		public void Pop()
		{

			int val = (int)stack.Pop();
			if (val == minElement)
			{

				minElement = (int)stack.Pop();
			}
		}

		public int Top()
		{
			return (int)stack.Peek(); // Top element.


		}

		public int GetMin()
		{
			return minElement;
		}
	}


}