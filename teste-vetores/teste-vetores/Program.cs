using System;
using System.Globalization;

namespace teste_vetores
{
	class Program
	{
		static void Main(string[] args)
		{
			DadosDoQuarto[] aluguel = new DadosDoQuarto[10];

			Console.Write("How many rooms will be rented? ");
			int n = int.Parse(Console.ReadLine());

			for(int i = 1; i <= n; i++)
			{
				Console.WriteLine();
				Console.WriteLine($"Rent #{i}:");
				Console.Write("Name: ");
				string name = Console.ReadLine();
				Console.Write("Email: ");
				string email = Console.ReadLine();
				Console.Write("Room: ");
				int m = int.Parse(Console.ReadLine());
				aluguel[m] = new DadosDoQuarto(name, email);
			}
			Console.WriteLine();
			Console.WriteLine("Busy rooms: ");
			for(int i = 0; i < 10; i++)
			{
				if (aluguel[i] != null)
				{
					Console.WriteLine(i + ": " + aluguel[i]);
				}
			}
		}
	}
}
