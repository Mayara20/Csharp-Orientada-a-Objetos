using System;
using System.Collections.Generic;
using System.IO;

namespace Exercicio_Dictionary_Proposto
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Insira o caminho do arquivo: ");
			string arquivo = Console.ReadLine();

			try
			{
				using (StreamReader sr = File.OpenText(arquivo))
				{
					Dictionary<string, int> candidato = new Dictionary<string, int>();

					while (!sr.EndOfStream)
					{
						string[] vet = sr.ReadLine().Split(',');
						string nomeCandidato = vet[0];
						int votos = int.Parse(vet[1]);

						if (candidato.ContainsKey(nomeCandidato))
						{
							candidato[nomeCandidato] += votos;
						}
						else
						{
							candidato[nomeCandidato] = votos;
						}
					}
					foreach(KeyValuePair<string, int> totalizando in candidato)
					{
						Console.WriteLine(totalizando.Key + ", " + totalizando.Value);
					}
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
