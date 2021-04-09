using System;
using Enums.Entities;
using Enums.Entities.Enumeracoes;

namespace Enums
{
	class Program
	{
		static void Main(string[] args)
		{
			Order pedidoOrder = new Order
			{
				Id = 1050,
				Moment = DateTime.Now,
				Status = OrderStatus.PendingPayment
			};
			Console.WriteLine(pedidoOrder);

			string teste = OrderStatus.PendingPayment.ToString();
			Console.WriteLine(teste);

			OrderStatus teste2 = Enum.Parse<OrderStatus>("Delivered");
			Console.WriteLine(teste2);
		}
	}
}
