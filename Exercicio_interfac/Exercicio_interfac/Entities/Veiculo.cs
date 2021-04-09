using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_interfac.Entities
{
	class Veiculo
	{
		public string Modelo { get; set; }
		public Veiculo()
		{
		}
		public Veiculo(string modelo)
		{
			Modelo = modelo;
		}
	}
}
