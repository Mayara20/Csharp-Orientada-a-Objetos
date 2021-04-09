using System;
using System.Collections.Generic;
using Exercicio_Resolvido_Class_Met_Abstratos.Entities.Enum;
using System.Text;

namespace Exercicio_Resolvido_Class_Met_Abstratos.Entities
{
	 abstract class Figura
	 {
		public Cor Cor { get; set; }
		public Figura (Cor cor)
		{
			Cor = cor;
		}
		public abstract double Area();
	 }
}
