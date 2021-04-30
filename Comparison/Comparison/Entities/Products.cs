using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace System
{
	class Products 
	{
		public string Nome { get; set; }
		public double Preco { get; set; }

		public Products(string nome, double preco)
		{
			Nome = nome;
			Preco = preco;
		}
		public override string ToString()
		{
			return Nome + ", " + Preco.ToString("F2", CultureInfo.InvariantCulture);
		}
		//public int CompareTo(Products outro)
		//{
		//	return Nome.ToUpper().CompareTo(outro.Nome.ToUpper());
		//}
	}
}
