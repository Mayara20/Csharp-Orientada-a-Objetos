using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Interfac.Entities
{
	class Parcelas
	{
		public DateTime Data { get; set; }
		public double Quantidade { get; set; }
		public Parcelas()
		{
		}
		public Parcelas(DateTime data, double quantidade)
		{
			Data = data;
			Quantidade = quantidade;
		}
		public override string ToString()
		{
			return Data.ToString("dd/MM/yyyy")
				+ " - " + Quantidade.ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
