using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Comparabli.Entities
{
	class Funcionarios : IComparable
	{
		public string Nome { get; set; }
		public double Salario { get; set; }
		public Funcionarios(string cvsFuncionario)
		{
			string[] vet = cvsFuncionario.Split(',');
			Nome = vet[0];
			Salario = double.Parse(vet[1], CultureInfo.InvariantCulture);
		}

		public override string ToString()
		{
			return Nome + "," + Salario.ToString("F2", CultureInfo.InvariantCulture);
		}

		public int CompareTo(object obj)
		{
			if(!(obj is Funcionarios))
			{
				throw new ArgumentException("Essa comparação não e possível");
			}
			Funcionarios outro = obj as Funcionarios;
			return Nome.CompareTo(outro.Nome);
		}
	}
}
