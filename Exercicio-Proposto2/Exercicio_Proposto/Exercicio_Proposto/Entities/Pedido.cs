using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_Proposto.Entities.Enums;
using System.Globalization;

namespace Exercicio_Proposto.Entities
{
	public class Pedido
	{
		public DateTime Momento { get; set; }
		public StatusPedido Status { get; set; }
		public Cliente Cliente { get; set; }
		public List<ItemDePedido> Itens { get; set; } = new List<ItemDePedido>();

		public Pedido()
		{
		}

		public Pedido(DateTime momento, StatusPedido status, Cliente cliente)
		{
			Momento = momento;
			Status = status;
			Cliente = cliente;
		}
		public void AddItem(ItemDePedido item)
		{
			Itens.Add(item);
		}
		public void RemoveItem(ItemDePedido item)
		{
			Itens.Remove(item);
		}
		public double Total()
		{
			double sum = 0;
			foreach(ItemDePedido item in Itens)
			{
				sum += item.SubTotal();
			}
			return Total();
		}
		public override string ToString()
		{
			StringBuilder x = new StringBuilder();
			x.AppendLine("Momento do pedido: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
			x.AppendLine("Estado do pedido: " + Status);
			x.AppendLine("Cliente: " + Cliente);
			x.AppendLine("Itens do pedido: ");
			foreach(ItemDePedido item in Itens)
			{
				x.AppendLine(item.ToString());
			}
			x.AppendLine("Preco total: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

			return x.ToString();
		}
	}
}
