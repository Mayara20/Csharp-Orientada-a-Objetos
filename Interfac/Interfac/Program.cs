using System;
using System.Globalization;
using Interfac.Entities;
using Interfac.Services;

namespace Interfac
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Insira os dados do contrato");
			Console.Write("Número: ");
			int numero = int.Parse(Console.ReadLine());
			Console.Write("Data (dd/MM/yyyy): ");
			DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
			Console.Write("Valor do contrato: ");
			double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Insira o numero de parcelas: ");
			int meses = int.Parse(Console.ReadLine());

			Contrato contrato = new Contrato(numero, data, valor);

			ContratosServicos servicos = new ContratosServicos(new ServicosPaypal());
			servicos.ProcessamentoContrato(contrato, meses);
			

			Console.WriteLine("Parcelas: ");
			foreach(Parcelas parcela in contrato.parcelas)
			{
				Console.WriteLine(parcela);
			}
		}
	}
}
