using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_interfac.Services
{
	class TaxaBrasileira : ITaxService
	{
		public double Taxa(double quantia)
		{
			if (quantia <= 100.0)
			{
				return quantia * 0.2;
			}
			else
			{
				return quantia * 0.15;
			}
		}
	}
}
