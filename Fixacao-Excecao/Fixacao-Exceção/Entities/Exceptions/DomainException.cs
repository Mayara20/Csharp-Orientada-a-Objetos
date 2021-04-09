using System;
using System.Collections.Generic;
using System.Text;

namespace Fixacao_Exceção.Entities.Exceptions
{
	class DomainException : ApplicationException
	{
		public DomainException(string message) : base(message)
		{
		}
	}
}
