﻿using System;

namespace Modificador_de_parametros_ref
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 10;

			Calculator.Triple(ref a);
			Console.WriteLine(a);
		}
	}
}
