using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Arquivos.Entities
{
	class Produtos
	{
		public string Nome { get; set; }
		public double Preco { get; set; }
		public int Quantidade { get; set; }

		public Produtos(string nome, double preco, int quantidade)
		{
			Nome = nome;
			Preco = preco;
			Quantidade = quantidade;
		}
		public double Total()
		{
			return Preco * Quantidade;
		}
	}
}
