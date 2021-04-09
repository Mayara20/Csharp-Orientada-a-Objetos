using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_interfac.Entities
{
	class Fatura
	{
		public double PagamentoBasico { get; set; }
		public double Taxa { get; set; }
		public Fatura()
		{
		}
		public Fatura(double pagamentoBasico, double taxa)
		{
			PagamentoBasico = pagamentoBasico;
			Taxa = taxa;
		}
		public double Total()
		{
			return PagamentoBasico + Taxa;
			//ou get { pagamentoBasico + Taxa; }
		}
		public override string ToString()
		{
			return "Pagamento básico: " + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
				+ "\nTaxa: " + Taxa.ToString("F2", CultureInfo.InvariantCulture)
				+ "\nPagamento total: " + Total().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
