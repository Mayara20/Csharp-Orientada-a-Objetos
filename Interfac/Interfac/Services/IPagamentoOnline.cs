using System;
using System.Collections.Generic;
using System.Text;

namespace Interfac.Services
{
	interface IPagamentoOnline
	{
		double JurosSimples(double juros, int meses);
		double Taxa(double taxa);
	}
}
