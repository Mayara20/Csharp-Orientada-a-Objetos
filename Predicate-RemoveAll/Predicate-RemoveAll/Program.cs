using System;
using System.Collections.Generic;
using System.Globalization;
using Predicate_RemoveAll.Entities;

namespace Predicate_RemoveAll
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Produto> list = new List<Produto>();
			list.Add(new Produto("Televisão", 900.00));
			list.Add(new Produto("Mouse", 50.00));
			list.Add(new Produto("Tablet", 350.50));
			list.Add(new Produto("Hd Case", 80.90));

			list.RemoveAll(EdicaoProduto);
			//ou list.RemoveAll(p => p.Preco >= 100.00)
			foreach(Produto p in list)
			{
				Console.WriteLine(p);
			}
		}
		public static bool EdicaoProduto(Produto p)
		{
			return p.Preco >= 100.00;
		}
	}
}
