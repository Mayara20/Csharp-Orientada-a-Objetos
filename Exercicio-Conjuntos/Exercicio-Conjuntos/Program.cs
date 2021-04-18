using System;
using System.IO;
using System.Collections.Generic;
using Exercicio_Conjuntos.Entities;

namespace Exercicio_Conjuntos
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<RegistroLog> set = new HashSet<RegistroLog>();

			Console.Write("Insira o caminho do arquivo: ");
			string arquivo = Console.ReadLine();

			try
			{
				using(StreamReader sr = File.OpenText(arquivo))
				{
					while (!sr.EndOfStream)
					{
						string[] vet = sr.ReadLine().Split(' ');
						string nome = vet[0];
						DateTime instante = DateTime.Parse(vet[1]);
						set.Add(new RegistroLog { NomeUsuario = nome, Instante = instante});
					}
					Console.WriteLine("Total de usuários: " + set.Count);	
				}
			}
			catch(Exception Ex)
			{
				Console.WriteLine("ERROR!");
				Console.WriteLine(Ex.Message);
			}
		}
	}
}
