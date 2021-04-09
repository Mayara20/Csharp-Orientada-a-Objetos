using System;
using System.Collections.Generic;
using Exercicio_Proposto.Entities;
using System.Text;
using System.Globalization;

namespace Exercicio_Proposto.Entities
{
	public class ItemDePedido
	{
		public int Quantidade { get; set; }
		public double Preco { get; set; }
		public Produto Produto { get; set; }
		public ItemDePedido()
		{
		}

		public ItemDePedido(int quantidade, double preco, Produto produto)
		{
			Quantidade = quantidade;
			Preco = preco;
			Produto = produto;
		}
		public double SubTotal()
		{
			return Quantidade * Preco;
		}
		public override string ToString()
		{
			return Produto.Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture)
				+ "Quantidade: " + Quantidade + ", Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
