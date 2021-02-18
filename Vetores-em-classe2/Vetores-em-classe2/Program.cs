using System;
using System.Globalization;

namespace Vetores_em_classe2
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			Product[] vet = new Product[n];

			for(int i = 0; i < n; i++)
			{
				string name = Console.ReadLine();
				double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				vet[i] = new Product(name, price);
			}
			double sum = 0.0;
			for (int i = 0; i < n; i++)
			{
				sum += vet[i].Price;
			}
			double avg = sum / n;
			Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
		}
	}
}
