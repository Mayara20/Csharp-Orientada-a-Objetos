using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Fixacao_Abstract
{
	class Program
	{
		static void Main(string[] args)
		{
			List<TaxaImpostos> list = new List<TaxaImpostos>();

			Console.Write("Entre com o número de Contribuintes:");
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				Console.WriteLine($"Dados do Contribuinte #{i}");
				Console.Write("Física ou Jurídica (F/J)?");
				char con = char.Parse(Console.ReadLine());
				Console.Write("Nome: ");
				string nome = Console.ReadLine();
				Console.Write("Renda Anual: ");
				double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				if (con == 'f' || con == 'F')
				{
					Console.Write("Gastos com saúde: ");
					double gastos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					list.Add(new Fisica(nome,renda,gastos));
				}
				else if(con == 'j' || con == 'J')
				{
					Console.Write("Número de funcionários: ");
					int funcionarios = int.Parse(Console.ReadLine());
					list.Add(new Juridica(nome, renda, funcionarios));
				}
			}
			double soma = 0.0;
			Console.WriteLine();
			Console.WriteLine("Impostos Pagos: ");
			foreach(TaxaImpostos taxa in list)
			{
				double tax = taxa.Impostos();
				Console.WriteLine(taxa.Nome + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
				soma += tax;
			}
			Console.WriteLine();
			Console.WriteLine("Taxa Total: $" + soma.ToString("F2",CultureInfo.InvariantCulture));
		}
	}
}
