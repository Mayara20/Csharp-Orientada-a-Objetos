using System;
using System.Collections.Generic;

namespace testando_apenas
{
	class Program
	{
		static void Main(string[] args)
		{
			//List<string> list = new List<string>();

			//list.Add("jao");
			//list.Add("caio");
			//list.Insert(0, "joana");
			//foreach(string obj in list)
			//{
			//	Console.WriteLine(obj);
			//}
			//Console.WriteLine(list.Count);



			List<Pessoa> pessoas = new List<Pessoa>();

			Pessoa mayara = new Pessoa();
			mayara.NomeCompleto = "Mayara Meireles Santos";
			mayara.Idade = 20;

			Pessoa larissa = new Pessoa();
			larissa.NomeCompleto = "Larissa Ferreira Santos";
			larissa.Idade = 24;

			pessoas.Add(mayara);
			pessoas.Add(larissa);

			ImprimirPessoas(pessoas);



		}

		static void ImprimirPessoas(List<Pessoa> pessoas)
		{
			//Pessoa mayara = pessoas.Find(x => x.NomeCompleto.Contains("Mayara"));
			//Pessoa mayara = pessoas.Find(x => x.NomeCompleto == "Mayara");
			//Pessoa mayara = pessoas.FindLast(x => x.NomeCompleto.Contains("Santos"));

			//pessoas.RemoveAll(x => x.NomeCompleto == "Mayara Meireles Santos");
			//pessoas.RemoveAll(x => x.NomeCompleto.Contains("Santos"));
			pessoas.RemoveAt(2);


			foreach (Pessoa pessoa in pessoas)
			{
				Console.WriteLine(pessoa.NomeCompleto);
				Console.WriteLine(pessoa.Idade);
			}
		}


	}
}
