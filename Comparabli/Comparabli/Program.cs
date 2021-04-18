using System;
using Comparabli.Entities;
using System.Collections.Generic;
using System.IO;

namespace Comparable
{
	class Program
	{
		static void Main(string[] args)
		{
			string dados = @"C:\DesenvolvimentoMayara\Nomes.txt";

			try
			{
				using(StreamReader sr = File.OpenText(dados))
				{
					List<Funcionarios> list = new List<Funcionarios>();
					while (!sr.EndOfStream)
					{
						list.Add(new Funcionarios(sr.ReadLine()));
					}
					list.Sort();
					foreach(Funcionarios fun in list)
					{
						Console.WriteLine(fun);
					}
				}
			}
			catch (IOException Ex)
			{
				Console.WriteLine("ERROR!");
				Console.WriteLine(Ex.Message);
			}
		}
	}
}
