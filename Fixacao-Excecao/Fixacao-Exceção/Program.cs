using System;
using System.Globalization;
using Fixacao_Exceção.Entities;
using Fixacao_Exceção.Entities.Exceptions;

namespace Fixacao_Exceção
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Entre com dados a conta");
			Console.Write("Numero: ");
			int numero = int.Parse(Console.ReadLine());
			Console.Write("Titular: ");
			string titular = Console.ReadLine();
			Console.Write("Saldo inicial: ");
			double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Limite de saque: ");
			double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Conta conta = new Conta(numero, titular, saldo, limite);

			Console.WriteLine();
			Console.Write("Insira o valor para sacar: ");
			double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			try
			{
				conta.Saque(quantia);
				Console.WriteLine("Novo balanço: " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
			}
			catch(DomainException e)
			{
				Console.WriteLine("Erro saque: " + e.Message);
			}
		}
	}
}
