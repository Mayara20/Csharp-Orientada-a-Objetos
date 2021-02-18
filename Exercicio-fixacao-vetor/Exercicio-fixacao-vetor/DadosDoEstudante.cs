using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_fixacao_vetor
{
	class DadosDoEstudante
	{
		public string Name { get; set; }
		public string Email { get; set; }

		public DadosDoEstudante(string name, string email)
		{
			Name = name;
			Email = email;
		}
		public override string ToString()
		{
			return Name + ", " + Email;
		}
	}
}
