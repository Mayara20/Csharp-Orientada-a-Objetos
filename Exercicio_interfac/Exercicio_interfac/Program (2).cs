using System;
using Exercicio_Interfac.Entities;
using Exercicio_Interfac.Services;
using System.Globalization;

namespace Exercicio_Interfac.Entities.Services
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
			Console.Write("Valor do Contrato: ");
			double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Insira quantidade de parcelas: ");
			int meses = int.Parse(Console.ReadLine());

			Contrato contrato = new Contrato(numero, data, valor);

			ContratoServico contratoServico = new ContratoServico(new ServicoPagamento());
			contratoServico.ProcessandoContrato(contrato,meses);

			Console.WriteLine("Parcelas");
			foreach(Parcelas parcela in contrato.parcelas)
			{
				Console.WriteLine(parcela);
			}

		}
	}
}
