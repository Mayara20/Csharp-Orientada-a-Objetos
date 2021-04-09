using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Proposto_Polimorfismo.Entities
{
	class FuncionariosTerceirizados : Funcionario
	{
		public double DespesaAdicional { get; set; }
		public FuncionariosTerceirizados()
		{
		}
		public FuncionariosTerceirizados(string name, int hours, double valuePerHour, double despesaAdicional)
			: base(name, hours, valuePerHour)
		{
			DespesaAdicional = despesaAdicional;
		}
		public override double Payment()
		{
			return base.Payment() + 1.1 * DespesaAdicional;
		}
	}
}
