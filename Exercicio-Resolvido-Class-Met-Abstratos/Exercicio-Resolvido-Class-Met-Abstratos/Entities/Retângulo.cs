using System;
using System.Collections.Generic;
using Exercicio_Resolvido_Class_Met_Abstratos.Entities.Enum;

namespace Exercicio_Resolvido_Class_Met_Abstratos.Entities
{
	class Retângulo : Figura
	{
		public double Largura { get; set; }
		public double Altura { get; set; }
		public Retângulo(double largura, double altura, Cor cor) : base(cor)
		{
			Largura = largura;
			Altura = altura;
		}

		public override double Area()
		{
			return Largura * Altura;
		}
	}
}
