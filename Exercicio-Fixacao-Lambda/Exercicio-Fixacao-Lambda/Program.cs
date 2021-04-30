using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_Fixacao_Lambda.Entities;
using System.IO;
using System.Linq;


namespace Exercicio_Fixacao_Lambda
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Insira o caminho completo do arquivo: ");
			string arquivo = Console.ReadLine();
			Console.Write("Entre com o salário: ");
			double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			List<Funcionarios> funcionarios = new List<Funcionarios>();

			try
			{
				using(StreamReader sr = File.OpenText(arquivo))
				{
					while (!sr.EndOfStream)
					{
						string[] dados = sr.ReadLine().Split(',');
						string nome = dados[0];
						string email = dados[1];
						double salario = double.Parse(dados[2], CultureInfo.InvariantCulture);
						funcionarios.Add(new Funcionarios(nome, email, salario));
					}
				}
				var emailsOrdenados = funcionarios.Where(x => x.Salario > valor).OrderBy(x => x.Email).Select(x => x.Email);
				Console.WriteLine("Email de pessoas cujo salário é superior a " + valor.ToString("F2", CultureInfo.InvariantCulture) + ": ");
				foreach(string email in emailsOrdenados)
				{
					Console.WriteLine(email);
				}
				var somaSalarios = funcionarios.Where(x => x.Nome[0] == 'M').Sum(x => x.Salario);
				Console.WriteLine("Soma do salário de pessoas cujo nome começa com a inicial 'M': " + somaSalarios.ToString("F2",CultureInfo.InvariantCulture));
			}
			catch (Exception Ex)
			{
				Console.WriteLine("ERROR!");
				Console.WriteLine(Ex.Message);
			}
		}
	}
}
