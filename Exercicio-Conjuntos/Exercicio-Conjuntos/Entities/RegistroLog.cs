using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Conjuntos.Entities
{
	class RegistroLog
	{
		public string NomeUsuario { get; set; }
		public DateTime Instante { get; set; }
		public override int GetHashCode()
		{
			return NomeUsuario.GetHashCode();
		}
		public override bool Equals(object obj)
		{
			if(!(obj is RegistroLog))
			{
				return false;
			}
			RegistroLog other = obj as RegistroLog;
			return NomeUsuario.Equals(other.NomeUsuario);
		}
	}
}
 