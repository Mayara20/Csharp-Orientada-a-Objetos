using System;
using Exercicio_Proposto.Entities.Enums;
using System.Globalization;

namespace Exercicio_Proposto.Entities.Enums
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Entre com dados do Cliente: ");
				Console.Write("Nome: ");
				string NomeCliente = Console.ReadLine();
				Console.Write("Email: ");
				string EmailCliente = Console.ReadLine();
				Console.Write("Data de Nascimento (DD/MM/YYYY): ");
				DateTime NascimentoCliente = DateTime.Parse(Console.ReadLine());

				Console.WriteLine("Entre com dados do Pedido: ");
				Console.Write("Status: ");
				StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());

				Cliente cliente = new Cliente(NomeCliente, EmailCliente, NascimentoCliente);
				Pedido pedido = new Pedido(DateTime.Now, status, cliente);

				Console.Write("Quantos itens para este pedido? ");
				int n = int.Parse(Console.ReadLine());
				for (int i = 1; i <= n; i++)
				{
					Console.WriteLine($"Entre com o #{i} Pedido: ");
					Console.Write("Nome do Produto: ");
					string NomeProduto = Console.ReadLine();
					Console.Write("Preco do Produto: ");
					double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					Produto produto = new Produto(NomeProduto, precoProduto);

					Console.Write("Quantidade: ");
					int Quantidade = int.Parse(Console.ReadLine());
					ItemDePedido item = new ItemDePedido(Quantidade, precoProduto, produto);

					pedido.AddItem(item);
				}
				Console.WriteLine();
				Console.WriteLine("RESUMO DO PEDIDO: ");
				Console.WriteLine(pedido.ToString());
			}
			catch (Exception e)
			{
				var erro = e;
			}


		}
	}
}
