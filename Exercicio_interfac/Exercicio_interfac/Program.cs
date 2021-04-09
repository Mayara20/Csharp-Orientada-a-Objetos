using System;
using System.Globalization;
using Exercicio_interfac.Entities;
using Exercicio_interfac.Services;

namespace Exercicio_interfac
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Dados da locação ");
			Console.Write("Carro de Modelo: ");
			string modelo = Console.ReadLine();
			Console.Write("Retirada (dd/MM/yyyy hh:mm): ");
			DateTime retirada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
			Console.Write("Entrega (dd/MM/yyyy hh:mm): ");
			DateTime entrega = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
			Console.Write("Insira o preço por hora: ");
			double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Insira o preço por dia: ");
			double dias = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			AluguelCarro carro = new AluguelCarro(retirada, entrega, new Veiculo(modelo));
			ServicosAluguel aluguel = new ServicosAluguel(horas, dias,new TaxaBrasileira());
			aluguel.ProcessamentoFaturamento(carro);

			Console.WriteLine("FATURA");
			Console.WriteLine(carro.Fatura);
		}
	}
}
