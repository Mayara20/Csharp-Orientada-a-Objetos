using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Interfac.Services
{
	interface IPagamentosOnline
	{
		double Taxa(double quantia);

		double JurosSimples(double quantia, int meses);
	}
}
