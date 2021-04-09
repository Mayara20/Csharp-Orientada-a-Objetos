using System;
using Sobreposição__2.Entities;

namespace Sobreposição__2
{
	class Program
	{
		static void Main(string[] args)
		{
			Conta conta = new Conta(105, "Joao", 100.0);
			ContaNegocios negocios = new ContaNegocios(115, "Caio", 150.0, 200.00);
			ContaPoupanca poupanca = new ContaPoupanca(0997, "Nike", 250.0, 0.01);

			////UPCASTING
			//Conta x = new ContaNegocios(333, "Anna", 30.0, 0.0);
			//Conta y = new ContaPoupanca(441, "Bob", 20.0, 20.0);

			////DOWNCASTING
			//ContaNegocios r = (ContaNegocios)x;
			////Conta n = (ContaPoupanca)x;
			conta.Saque(15.0);
			negocios.Saque(45.00);
			poupanca.Saque(50.00);

			Console.WriteLine(conta.Saldo);
			Console.WriteLine(negocios.Saldo);
			Console.WriteLine(poupanca.Saldo);
		}
	}
}
