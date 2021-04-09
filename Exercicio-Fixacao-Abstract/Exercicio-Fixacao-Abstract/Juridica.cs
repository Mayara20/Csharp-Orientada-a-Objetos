using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixacao_Abstract
{
	class Juridica : TaxaImpostos
	{
		public int NumeroFuncionarios { get; set; }
		public Juridica()
		{
		}
		public Juridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
		{
			NumeroFuncionarios = numeroFuncionarios;
		}
		public override double Impostos()
		{
			if (NumeroFuncionarios > 10)
			{
				return RendaAnual * 0.14;
			}
			else
			{
				return RendaAnual * 0.16;
			}
		}
	}
}
