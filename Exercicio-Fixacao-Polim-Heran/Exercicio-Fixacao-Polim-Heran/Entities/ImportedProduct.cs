using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_Fixacao_Polim_Heran.Entities
{
	sealed class ImportedProduct : Product
	{
		public double CustomFee { get; set; }
		public ImportedProduct()
		{
		}
		public ImportedProduct(string name, double price, double customFee) : base(name, price)
		{
			CustomFee = customFee;
		}
		public double PriceTot()
		{
			return Price + CustomFee;
		}
		public override string PriceTag()
		{
			return Name + " $ " + PriceTot().ToString("F2", CultureInfo.InvariantCulture) 
				+ " (Customs fee: $ "
				+ CustomFee.ToString("F2", CultureInfo.InvariantCulture) 
				+ ")" ;
		}
	}
}
