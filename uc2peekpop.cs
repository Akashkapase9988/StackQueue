using System;
using System.Collections.Generic;
using System.Text;

namespace day14stackqueue
{
	
	class uc2
	{
		public static void peekpop()
		{
			//Creating a Stack<T> of int type i.e Stack<int>, to hold int values
			Stack<int> st = new Stack<int>();


			//Calling the Push() method to push elements into the Stack<int>
			//New element is always added to the top of the Stack<int>
			st.Push(10);
			st.Push(32);
			st.Push(12);
			st.Push(3);
			st.Push(27);

			//Printing the contents of Stack<int>
			Console.WriteLine("The contents of Stack<int>: ");
			foreach (int element in st)
				Console.WriteLine(element);


			//Calling the Pop() method to remove the top element of the Stack<int>
			Console.WriteLine("Popping out the top element = " + st.Pop());
			Console.WriteLine("Popping out the next top element = " + st.Pop());


			//Calling the Peek() method which only gets the top element of the Stack<int>, without removing it
			Console.WriteLine("Peeking at the current top element = " + st.Peek());


			//Printing the updated contents of Stack<int>
			Console.WriteLine("The updated contents of Stack<int>: ");
			foreach (int element in st)
				Console.WriteLine(element);
		}	
	}
}
