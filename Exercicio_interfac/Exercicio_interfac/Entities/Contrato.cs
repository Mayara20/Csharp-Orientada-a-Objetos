using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Interfac.Entities
{
	class Contrato
	{
		public int Numero { get; set; }
		public DateTime Data { get; set; }
		public double ValorTotal { get; set; }
		public List<Parcelas> parcelas { get; set; }
		public Contrato()
		{
		}
		public Contrato(int numero, DateTime data, double valorTotal)
		{
			Numero = numero;
			Data = data;
			ValorTotal = valorTotal;
			parcelas = new List<Parcelas>();
		}
		public void addParcelas(Parcelas parcela)
		{
			parcelas.Add(parcela);
		}
	}
}
