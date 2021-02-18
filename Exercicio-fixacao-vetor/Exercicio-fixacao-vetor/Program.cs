using System;

namespace Exercicio_fixacao_vetor
{
	class Program
	{
		static void Main(string[] args)
		{
			DadosDoEstudante[] vet = new DadosDoEstudante[10];

			Console.Write("How many rooms will be rented? ");
			int n = int.Parse(Console.ReadLine());

			Console.WriteLine();
			Console.WriteLine("Rent #(i):" );
			Console.Write("Name: ");
			string name = Console.ReadLine();
			Console.Write("Email: ");
			string email = Console.ReadLine();
			Console.WriteLine("Room: ");
			int quarto = int.Parse(Console.ReadLine());
			vet[quarto] = new DadosDoEstudante(name,email);

			Console.WriteLine("Busy rooms: ");

		}
	}
}
