using System;
using System.Collections.Generic;
using System.Text;

namespace Comparando_Igualdades_Colecoes.Entities
{
	class Products
	{
		public string Name { get; set; }
		public double Price { get; set; }

		public Products(string name, double price)
		{
			Name = name;
			Price = price;
		}

		public override int GetHashCode()
		{
			return Name.GetHashCode() + Price.GetHashCode();
		}
		public override bool Equals(object obj)
		{
			if(!(obj is Products))
			{
				return false;
			}
			Products other = obj as Products;
			return Name.Equals(other.Name) && Price.Equals(other.Price);
		}
	}
}
