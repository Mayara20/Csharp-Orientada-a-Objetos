using System;
using System.Collections.Generic;
using Func_Delegate.Entities;
using System.Linq;

namespace Func_Delegate
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Produto> list = new List<Produto>();

			list.Add(new Produto("Televisão", 900.00));
			list.Add(new Produto("Mouse", 50.00));
			list.Add(new Produto("Tablet", 350.00));
			list.Add(new Produto("Hd Case", 80.90));

			//Func<Produto, string> func = NomeMaiusculo;
			//Func<Produto, string> func = p => p.Nome.ToUpper();

			List<string> prod = list.Select(p => p.Nome.ToUpper()).ToList();

			foreach(string p in prod)
			{
				Console.WriteLine(p);
			}
		}
		//static string NomeMaiusculo(Produto p)
		//{
		//	return p.Nome.ToUpper();
		//}
	}
}
