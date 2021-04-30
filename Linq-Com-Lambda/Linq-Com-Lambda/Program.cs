using System;
using Linq_Com_Lambda.Entities;
using System.Linq;
using System.Collections.Generic;

namespace Linq_Com_Lambda
{
	class Program
	{

		static void Main(string[] args)
		{
			Categoria A = new Categoria() { Id = 1, Nome = "Ferramentas", Nivel = 2 };
			Categoria B = new Categoria() { Id = 2, Nome = "Eletronicos", Nivel = 1 };
			Categoria C = new Categoria() { Id = 3, Nome = "Eletrodomésticos", Nivel = 1 };

			try
			{
				List<Produto> list = new List<Produto>()
			{
				new Produto() {Id = 1, Nome = "Computador", Preco = 1100.00, Categoria = B},
				new Produto() {Id = 2, Nome = "Martelo", Preco = 90.00, Categoria = A},
				new Produto() {Id = 3, Nome = "Geladeira", Preco = 1700.00, Categoria = C},
				new Produto() {Id = 4, Nome = "Notebook", Preco = 1300.00, Categoria = B},
				new Produto() {Id = 5, Nome = "Serra", Preco = 80.00, Categoria = A},
				new Produto() {Id = 6, Nome = "Tablet", Preco = 700.00, Categoria = B},
				new Produto() {Id = 7, Nome = "Aspirador de pó", Preco = 700.00, Categoria = C},
				new Produto() {Id = 8, Nome = "Televisão", Preco = 350.00, Categoria = C},
				new Produto() {Id = 9, Nome = "Celular", Preco = 1800.00, Categoria = B},
				new Produto() {Id = 10, Nome = "Caixa de som", Preco = 700.00, Categoria = C},
				new Produto() {Id = 11, Nome = "Furadeira", Preco = 70.00, Categoria = A},
				new Produto() {Id = 12, Nome = "Alicate", Preco = 50.00, Categoria = A}
			};

				//var t1 = list.Where(x => x.Categoria.Nivel == 1 && x.Preco < 900.00);
				var t1 =
					 from x in list
					 where x.Categoria.Nivel == 1 && x.Preco < 900.00
					 select x;
				Imprimir("Nível 1 e Preço < R$900.00: ", t1);
				//var t2 = list.Where(x => x.Categoria.Nome == "Ferramentas").Select(x => x.Nome);
				var t2 =
					from x in list
					where x.Categoria.Nome == "Ferramentas"
					select x.Nome;
				Imprimir("Nome de Produtos das Ferramentas: ", t2);
				//var t3 = list.Where(x => x.Nome[0] == 'M').Select(x => new {x.Nome, x.Preco, categoriaNome = x.Categoria.Nome});
				var t3 =
					from x in list
					where x.Nome[0] == 'M'
					select new
					{
						x.Nome,
						x.Preco,
						CategoriaNome = x.Categoria.Nome
					};
				Imprimir("Nomes começados em 'M' e objeto anônimo: ", t3);
				//var t4 = list.Where(x => x.Categoria.Nivel == 1).OrderBy(x => x.Preco).ThenBy(x => x.Nome);
				var t4 =
					from x in list
					where x.Categoria.Nivel == 1
					orderby x.Nome
					orderby x.Preco
					select x;
				Imprimir("Nível 1, Ordem por preço, em seguida, por nome: ", t4);
				//var t5 = t4.Skip(2).Take(4);
				var t5 =
					(from x in t4
					 select x).Skip(2).Take(4);
				Imprimir("Nível 1, Ordem por preço,então por nome pular 2, pegar 4: ", t5);
				//var t6 = list.First();
				var t6 =
					(from x in list
					 select x).First();
				Console.WriteLine("Primeiro: " + t6);
				//var t7 = list.Where(x => x.Preco > 4000.00).FirstOrDefault();
				var t7 =
					(from x in list
					 where x.Preco > 4000.00
					 select x).FirstOrDefault();
				Console.WriteLine("Primeiro ou Padrão: " + t7);
				//var t8 = list.Where(x => x.Id == 4).Single();
				//Console.WriteLine("Single or default: " + t8);
				//var t9 = list.Where(x => x.Id == 40).SingleOrDefault();
				//Console.WriteLine("Single or default: " + t9);
				//Console.WriteLine();
				//var t10 = list.Max(x => x.Preco);
				//Console.WriteLine("Preço máximo: " + t10);
				//var t11 = list.Min(x => x.Preco);
				//Console.WriteLine("Preço mínimo: " + t11);
				//var t12 = list.Where(x => x.Categoria.Id == 1).Sum(x => x.Preco);
				//Console.WriteLine("Soma dos preços: " + t12);
				//var t13 = list.Where(x => x.Categoria.Id == 1).Average(x => x.Preco);
				//Console.WriteLine("Categoria 1 de Média dos preços: " + t13);
				//var t14 = list.Where(x => x.Categoria.Id == 6).Select(x => x.Preco).DefaultIfEmpty(0.0).Average();
				//Console.WriteLine("Categoria 6 de Média dos preços: " + t14);
				//var t15 = list.Where(x => x.Categoria.Id == 6).Select(x => x.Preco).Aggregate(0.0, (i, j) => i + j);
				//Console.WriteLine("Categoria 1 e agregação de soma: " + t15);
				Console.WriteLine();
				//var t16 = list.GroupBy(x => x.Categoria);
				var t16 =
					from x in list
					group x by x.Categoria;
				foreach(IGrouping<Categoria, Produto> grupo in t16)
				{
					Console.WriteLine("Categoria " + grupo.Key.Nome + ": ");
					foreach(Produto produto in grupo)
					{
						Console.WriteLine(produto);
					}
					Console.WriteLine();
				}
			}
			catch(Exception Ex)
			{
				Console.WriteLine("Error!");
				Console.WriteLine(Ex.Message);
			}
		}
	

		static void Imprimir<T>(string Mensagem, IEnumerable<T> Colecao)
		{
			Console.WriteLine(Mensagem);
			foreach (T objeto in Colecao)
			{
				Console.WriteLine(objeto);
			}
			Console.WriteLine();
		}
	}
}
