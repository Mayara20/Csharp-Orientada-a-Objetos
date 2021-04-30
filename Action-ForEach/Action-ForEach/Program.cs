using System;
using System.Collections.Generic;
using System.Globalization;
using Action_ForEach.Entities;

namespace Action_ForEach
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Produto> list = new List<Produto>();

			list.Add(new Produto("Tv", 900.00));
			list.Add(new Produto("Mouse", 50.00));
			list.Add(new Produto("Tablet", 350.50));
			list.Add(new Produto("HD Case", 80.90));

			//Action<Produto> act = AtualizandoPreco;
			//Action<Produto> act = p => { p.Preco += p.Preco * 0.1; };

			list.ForEach(p => { p.Preco += p.Preco * 0.1; });
			
			foreach(Produto x in list)
			{
				Console.WriteLine(x);
			}

		}
		 static void AtualizandoPreco(Produto p)
		{
			p.Preco += p.Preco * 0.1;
		}
	}
}
