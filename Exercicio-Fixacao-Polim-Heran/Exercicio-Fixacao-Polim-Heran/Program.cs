using System;
using System.Globalization;
using Exercicio_Fixacao_Polim_Heran.Entities;
using System.Collections.Generic;

namespace Exercicio_Fixacao_Polim_Heran
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the number of products: ");
			int n = int.Parse(Console.ReadLine());

			List<Product> produtos = new List<Product>();

			for (int i = 1; i <= n; i++)
			{
				Console.WriteLine($"Product #{i} data: ");
				Console.Write("Commom, used or imported (c/u/i)? ");
				char resp = char.Parse(Console.ReadLine());
				Console.Write("Name: ");
				string name = Console.ReadLine();
				Console.Write("Price: ");
				double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				if (resp == 'u' || resp == 'U')
				{
					Console.Write("Manufacture date (DD/MM/YYYY): ");
					DateTime facture = DateTime.Parse(Console.ReadLine());
					produtos.Add(new UsedProduct(name, price, facture));
				}
				else if (resp == 'i' || resp == 'I')
				{
					Console.Write("Customs fee: ");
					double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					produtos.Add(new ImportedProduct(name, price, fee));
				}
				else
				{
					produtos.Add(new Product(name, price));
				}
			}
			Console.WriteLine();
			Console.WriteLine("PRICE TAGS: ");
			foreach (Product prod in produtos)
			{
				Console.WriteLine(prod.PriceTag());
			}
			
		}
	}
}
