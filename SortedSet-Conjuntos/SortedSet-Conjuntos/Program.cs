using System;
using System.Collections.Generic;

namespace SortedSet_Conjuntos
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedSet<int> a = new SortedSet<int>() { 1, 5, 7, 2, 8 };
			SortedSet<int> b = new SortedSet<int>() { 3, 7, 4, 8, 9 };

			SortedSet<int> c = new SortedSet<int>(a);
			c.UnionWith(b);
			PrintCollections(c);

			SortedSet<int> d = new SortedSet<int>(a);
			d.IntersectWith(b);
			PrintCollections(d);

			SortedSet<int> e = new SortedSet<int>(b);
			e.ExceptWith(a);
			PrintCollections(e);
		}
		static void PrintCollections<T>(IEnumerable<T> collections)
		{
			foreach(T obj in collections)
			{
				Console.Write(obj + " ");
			}
			Console.WriteLine();
		}
	}
}
