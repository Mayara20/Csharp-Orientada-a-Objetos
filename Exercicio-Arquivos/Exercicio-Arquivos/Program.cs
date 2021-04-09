using System;
using System.IO;
using System.Globalization;
using Exercicio_Arquivos.Entities;

namespace Exercicio_Arquivos
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Insira o caminho do arquivo:");
			string arquivo = Console.ReadLine();

			try
			{
				string[] lines = File.ReadAllLines(arquivo);

				string origem = Path.GetDirectoryName(arquivo);
				string folder = origem + @"\out";
				string file = folder + @"\summary.csv";

				Directory.CreateDirectory(folder);

				using (StreamWriter sw = File.AppendText(file)) {
					foreach (string line in lines)
					{
						string[] test = line.Split(",");
						string nome = test[0];
						double preco = double.Parse(test[1],CultureInfo.InvariantCulture);
						int quantidade = int.Parse(test[2]);

						Produtos produto = new Produtos(nome, preco, quantidade);

						sw.WriteLine(produto.Nome + "," + produto.Total().ToString("F2", CultureInfo.InvariantCulture));
					}
				}

			}
			catch(IOException Ex)
			{
				Console.WriteLine("ERROR!");
				Console.WriteLine(Ex.Message);
			}
		}
	}
}
