using System;
using System.Collections.Generic;
using System.Text;

namespace Generics1
{
	class PrintService<T>
	{
		private T[] values = new T[10];
		private int count = 0;

		public void addValue(T value)
		{
			if(count == 10)
			{
				throw new InvalidOperationException("PrintService is full");
			}
			values[count] = value;
			count++;
		}

		public T Firts()
		{
			if(count == 0)
			{
				throw new InvalidOperationException("PrintService is empty");
			}
			return values[0];
		}
		public void Print()
		{
			Console.Write("[");
			for(int i = 0; i < count - 1; i++)
			{
				Console.Write(values[i] + ", ");
			}
			if(count > 0)
			{
				Console.Write(values[count - 1]);
			}
			Console.WriteLine("]");
		}
	}
}
