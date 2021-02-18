using System;
using System.Collections.Generic;
using System.Text;

namespace Modificador_de_parametros_ref
{
	class Calculator
	{
		public static void Triple(ref int x)
		{
			x = x * 3;
		}
	}
}
