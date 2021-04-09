using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_interfac.Entities
{
	class AluguelCarro
	{
		public DateTime Retirada { get; set; }
		public DateTime Entrega { get; set; }
		public Veiculo Veiculo { get; set; }
		public Fatura Fatura { get; set; }

		public AluguelCarro()
		{
		}

		public AluguelCarro(DateTime retirada, DateTime entrega, Veiculo veiculo)
		{
			Retirada = retirada;
			Entrega = entrega;
			Veiculo = veiculo;
		}
	}
}
