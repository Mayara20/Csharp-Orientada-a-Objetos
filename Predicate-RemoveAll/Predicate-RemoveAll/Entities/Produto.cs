﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Predicate_RemoveAll.Entities
{
	class Produto
	{
		public string Nome { get; set; }
		public double Preco { get; set; }
		public Produto(string nome, double preco)
		{
			Nome = nome;
			Preco = preco;
		}
		public override string ToString()
		{
			return Nome + ", " + Preco.ToString("F2");
		}
	}
}