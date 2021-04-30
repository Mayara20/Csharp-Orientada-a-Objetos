using System;
using System.Collections.Generic;

namespace Comparison
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Products> list = new List<Products>();

			list.Add(new Products("Sabiá", 400.00));
			list.Add(new Products("Geladeira", 399.00));
			list.Add(new Products("Som", 200.00));
			list.Add(new Products("Garrafa", 15.00));

			//Comparison<Products> comp = (p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper();

			list.Sort((p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper()));

			foreach (Products prod in list)
			{
				Console.WriteLine(prod);
			}
		}
	}
}
