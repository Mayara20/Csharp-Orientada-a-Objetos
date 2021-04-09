using System;
using Exceções_Personalizadas.Entities;
using Exceções_Personalizadas.Entities.Exceptions;

namespace Exceções_Personalizadas
{
	class Program
	{
		static void Main(string[] args)
		{
			try { 
			Console.Write("Número do quarto: ");
			int n = int.Parse(Console.ReadLine());
			Console.Write("Data de Check-in (dd/MM/yyyy): ");
			DateTime checkin = DateTime.Parse(Console.ReadLine());
			Console.Write("Data de Check-out (dd/MM/yyyy): ");
			DateTime checkout = DateTime.Parse(Console.ReadLine());

			Reserva reserva = new Reserva(n, checkin, checkout);
			
			Console.WriteLine("Reserva: " + reserva);
			Console.WriteLine();
			Console.WriteLine("Insira os dados para atualizar a reserva: ");
			Console.Write("Data de Check-in (dd/MM/yyyy): ");
			checkin = DateTime.Parse(Console.ReadLine());
			Console.Write("Data de Check-out (dd/MM/yyyy): ");
			checkout = DateTime.Parse(Console.ReadLine());

			reserva.DatasAtualizacao(checkin, checkout);
			Console.WriteLine("Reserva: " + reserva);
			}
			catch (DomainException e)
			{
				Console.WriteLine("Erro em reserva: " + e.Message);
			}
		}
	}
}
