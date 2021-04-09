using System;
using System.Collections.Generic;
using System.Text;

namespace Sobreposição__2.Entities
{
	class ContaNegocios : Conta
	{
		public double LimiteEmprestimo { get; set; }
		public ContaNegocios()
		{
		}
		public ContaNegocios(int numero, string titular, double saldo, double limiteEmprestimo)
			: base(numero, titular, saldo)
		{
			LimiteEmprestimo = limiteEmprestimo;
		}
		public void Emprestimo(double valor)
		{
			Saldo += valor;
		}
	}
}
