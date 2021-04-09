using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Proposto.Entities
{
	public class Produto
	{
		public string Nome { get; set; }
		public double Preco { get; set; }
		public Produto()
		{
		}
		public Produto(string nome, double preco)
		{
			Nome = nome;
			Preco = preco;
		}
	}
}
