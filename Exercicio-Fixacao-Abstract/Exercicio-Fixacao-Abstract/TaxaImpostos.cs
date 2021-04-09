using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixacao_Abstract
{
	abstract class TaxaImpostos
	{
		public string Nome { get; set; }
		public double RendaAnual { get; set; }
		public TaxaImpostos()
		{
		}
		public TaxaImpostos(string nome, double rendaAnual)
		{
			Nome = nome;
			RendaAnual = rendaAnual;
		}
		public abstract double Impostos();
	}
}
