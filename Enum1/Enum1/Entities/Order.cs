using System;
using System.Collections.Generic;
using System.Text;
using Enum1.Entities.Enums;

namespace Enum1.Entities
{
	class Order
	{
		public int Id { get; set; }
		public DateTime Momento { get; set; }
		public StatusPedido Status { get; set; }

		public override string ToString()
		{
			return Id + "," + Momento + "," + Status;
		}
	}
}
