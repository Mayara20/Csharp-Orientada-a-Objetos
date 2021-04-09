using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_Fixacao_Polim_Heran.Entities
{
	sealed class UsedProduct : Product
	{
		public DateTime Manufacture { get; set; }
		public UsedProduct()
		{
		}

		public UsedProduct(string name, double price, DateTime manufacture) : base(name,price)
		{
			Manufacture = manufacture;
		}
		public override string PriceTag()
		{
			return Name + " (used) $" 
				+ Price.ToString("F2", CultureInfo.InvariantCulture)
				+ " (Manufacture date: " + Manufacture.ToString("dd/MM/yyyy")
				+ ")";
		}
	}
}
