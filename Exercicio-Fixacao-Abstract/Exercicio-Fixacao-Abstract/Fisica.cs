using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixacao_Abstract
{
	class Fisica : TaxaImpostos
	{
		public double GastosSaude { get; set; }
		public Fisica()
		{
		}

		public Fisica(string nome, double rendaAnual,double gastosSaude) : base(nome,rendaAnual)
		{
			GastosSaude = gastosSaude;
		}
		public override double Impostos()
		{
			if (RendaAnual < 20000.00)
			{
				return RendaAnual * 0.15 - GastosSaude * 0.5;
			}
			else 
			{
				return RendaAnual * 0.25 - GastosSaude * 0.5;
			}
		}
	}
}
