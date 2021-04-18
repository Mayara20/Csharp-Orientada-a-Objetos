using System;
using Exercicio_Interfac.Services;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Interfac.Services
{
	class ServicoPagamento : IPagamentosOnline
	{
		private double taxaPagamento = 0.02;
		private double jurosMes = 0.01;

		public double JurosSimples(double quantia, int meses)
		{
			return meses * quantia * jurosMes;
		}
		public double Taxa(double quantia)
		{
			return quantia * taxaPagamento;
		}
	}
}
