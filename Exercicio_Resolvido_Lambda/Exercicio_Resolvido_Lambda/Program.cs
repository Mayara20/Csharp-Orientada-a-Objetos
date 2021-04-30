using System;
using System.Collections.Generic;
using Exercicio_Resolvido_Lambda.Entities;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Exercicio_Resolvido_Lambda
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Insira o caminho do arquivo: ");
			string arquivo = Console.ReadLine();

			List<Produtos> list = new List<Produtos>();

			using (StreamReader sr = File.OpenText(arquivo))
			{
				while (!sr.EndOfStream)
				{
					string[] campoProdutos = sr.ReadLine().Split(',');
					string nome = campoProdutos[0];
					double preco = double.Parse(campoProdutos[1], CultureInfo.InvariantCulture);
					list.Add(new Produtos(nome, preco));
				}
			}
			var Media = list.Select(x => x.Preco).DefaultIfEmpty(0.0).Average();
			Console.WriteLine("Média de preços dos produtos: " + Media.ToString("F2", CultureInfo.InvariantCulture));

			var nomes = list.Where(x => x.Preco < Media).OrderByDescending(x => x.Nome).Select(x => x.Nome);
			foreach(string nome in nomes)
			{
				Console.WriteLine(nome);
			}
		}
	}
}
