using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Fixacao_Exceção.Entities.Exceptions;

namespace Fixacao_Exceção.Entities
{
	class Conta
	{
		public int Numero { get;private set; }
		public string Titular { get; set; }
		public double Saldo { get; set; }
		public double LimiteBancario { get; set; }
		public Conta()
		{
		}
		public Conta(int numero, string titular, double saldo, double limiteBancario)
		{
			Numero = numero;
			Titular = titular;
			Saldo = saldo;
			LimiteBancario = limiteBancario;
		}
		public void Deposito(double quantia)
		{
			Saldo += quantia;
		}
		public void Saque(double quantia)
		{
			if (quantia > LimiteBancario)
			{
				throw new DomainException("A quantia excedeu o limite de saque. ");
			}
			if (quantia > Saldo)
			{
				throw new DomainException("Não a saldo suficiente.");
			}
			Saldo -= quantia;
		}
	
	}
}
