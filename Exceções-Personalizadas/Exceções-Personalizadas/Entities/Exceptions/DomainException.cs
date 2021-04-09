using System;

namespace Exceções_Personalizadas.Entities.Exceptions
{
	class DomainException : ApplicationException
	{
		public DomainException(string message) : base(message)
		{
		}
	}
}
