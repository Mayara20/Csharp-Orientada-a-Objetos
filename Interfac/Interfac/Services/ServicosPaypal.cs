using System;
using System.Collections.Generic;
using System.Text;

namespace Interfac.Services
{
	class ServicosPaypal : IPagamentoOnline
	{
		private double PagTaxa = 0.02;
		private double JurosMes = 0.01;

		public double JurosSimples(double quantia,int meses)
		{
			return  meses * quantia * JurosMes;
		}
		public double Taxa(double quantia)
		{
			return quantia * PagTaxa;
		}
	}
}
