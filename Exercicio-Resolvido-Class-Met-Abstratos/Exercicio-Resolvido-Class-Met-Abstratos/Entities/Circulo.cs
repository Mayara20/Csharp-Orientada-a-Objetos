using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_Resolvido_Class_Met_Abstratos.Entities.Enum;

namespace Exercicio_Resolvido_Class_Met_Abstratos.Entities
{
	class Circulo : Figura
	{
		public double Raio { get; set; }

		public Circulo(double raio, Cor cor) : base(cor)
		{
			Raio = raio;
		}

		public override double Area()
		{
			return Math.PI * Raio * Raio;
		}
	}
}
