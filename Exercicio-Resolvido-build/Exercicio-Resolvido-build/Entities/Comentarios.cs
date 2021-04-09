using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Resolvido_build.Entities
{
	class Comentarios
	{
		public string Texto { get; set; }

		public Comentarios()
		{
		}
		public Comentarios(string texto)
		{
			Texto = texto;
		}
	}
}
