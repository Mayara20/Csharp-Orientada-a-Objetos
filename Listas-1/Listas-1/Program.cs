using System;
using System.Collections.Generic;

namespace Listas_1
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> list = new List<string>();

			list.Add("Maria");
			list.Add("Alex");
			list.Add("Bob");
			list.Add("Anna");
			list.Insert(2, "Marco");
			
			foreach(string dados in list)
			{
				Console.WriteLine(dados);
			}
			Console.WriteLine("List count: " + list.Count);
			Console.WriteLine("--------------------------------");
			string f1 = list.Find(x => x[0] == 'A');
			Console.WriteLine("Primeiro: " + f1);

			string f2 = list.FindLast(x => x[0] == 'A');
			Console.WriteLine("Último: " + f2);
			Console.WriteLine("--------------------------------");
			int pos1 = list.FindIndex(x => x[0] == 'A');
			Console.WriteLine("Primeira Posição 'A' : " + pos1);

			int pos2 = list.FindLastIndex(x => x[0] == 'A');
			Console.WriteLine("Última posição 'A' : " + pos2);

			List<string> list2 = list.FindAll(x => x.Length == 5);
			Console.WriteLine("--------------------------------");
			foreach(string dados in list2)
			{
				Console.WriteLine(dados);
			}
			Console.WriteLine("--------------------------------");
			list.Remove("Alex");
			foreach(string dados in list)
			{
				Console.WriteLine(dados);
			} /* 
			Console.WriteLine("--------------------------------");
			list.RemoveAt(3);
			foreach (string dados in list)
			{
				Console.WriteLine(dados);
			}
			list.RemoveRange(2, 2);
			foreach (string dados in list)
			{
				Console.WriteLine(dados);
			}*/
			Console.WriteLine("--------------------------------");
			list.RemoveAll(x => x[0] == 'M');
			foreach (string ll in list)
			{
				Console.WriteLine(ll);
			}
			Console.WriteLine("--------------------------------");
			
		}
	}
}