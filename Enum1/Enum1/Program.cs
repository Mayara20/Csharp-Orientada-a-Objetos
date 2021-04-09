using Enum1.Entities;
using Enum1.Entities.Enums;
using System;

namespace Enum1
{
	class Program
	{
		static void Main(string[] args)
		{
			Order order = new Order
			{
				Id = 1080,
				Momento = DateTime.Now,
				Status = StatusPedido.PagamentoPendente
			};
			Console.WriteLine(order);

			string txt = v.PendingPayment.ToString();
			Console.WriteLine(txt);
			StatusPedido nem = Enum.Parse<StatusPedido>("Delivered");
			Console.WriteLine(nem);
		}
	}
}
