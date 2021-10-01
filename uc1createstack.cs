using System;
using System.Collections.Generic;

namespace day14stack 
{
	class uc1
	{
		public static void Main(String[] ar)
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




		
		}
	}
}