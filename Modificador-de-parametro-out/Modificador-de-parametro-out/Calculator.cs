using System;
using System.Collections.Generic;
using System.Text;

namespace Modificador_de_parametro_out
{
	class Calculator
	{
		public static void Triple(int origin, out int result)
		{
			result = origin * 3;
		}
	}  
}