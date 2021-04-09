using System;
using System.Collections.Generic;
using System.Text;
using Exceções_Personalizadas.Entities.Exceptions;

namespace Exceções_Personalizadas.Entities
{
	class Reserva
	{
		public int NumeroQuarto { get; set; }
		public DateTime Checkin { get; set; }
		public DateTime Checkout { get; set; }
		public Reserva()
		{
		}
		public Reserva(int numeroQuarto, DateTime checkin, DateTime checkout)
		{
			if (checkout <= checkin)
			{
				throw new DomainException("As datas de reserva para atualização devem ser posteriores à data de check-in");
			}

			NumeroQuarto = numeroQuarto;
			Checkin = checkin; 
			Checkout = checkout;
		}
		public int Duration()
		{
			TimeSpan duration = Checkout.Subtract(Checkin); 
			return (int)duration.TotalDays;
		}
		public void DatasAtualizacao(DateTime checkin, DateTime checkout)
		{
			DateTime now = DateTime.Now;
			if (checkin < now || checkout < now)
			{
			   throw new DomainException("E As datas de reserva para atualização devem ser datas futuras");
			}
			if (checkout <= checkin)
			{
				throw new DomainException("As datas de reserva para atualização devem ser posteriores à data de check-in");
			} 
			Checkin = checkin;
			Checkout = checkout;
		}
		public override string ToString()
		{
			return "Quarto " + NumeroQuarto
				+ ", check-in: " + Checkin.ToString("dd/MM/yyyy")
				+ ", check-out: " + Checkout.ToString("dd/MM/yyyy")
				+ ", " + Duration() + " noites";
		}
	}
}
