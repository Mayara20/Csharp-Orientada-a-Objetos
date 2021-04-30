using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Introducao
{
	class Program
	{
		static void Main(string[] args)
		{
			//Criar Consulta
			int[] numeros = new int[] { 2, 4, 5, 6, 9 };

			// Definir a expressão
			var resultado = numeros.Where(x => x % 2 == 0).Select(x => x * 2);
			//ou IEnumerable<int> resultado = numeros.Where(x => x % 2 == 0).Select(x => x * 2);

			// Executar a Consulta
			foreach (int x in resultado)
			{
				Console.WriteLine(x);
			}
		}
	}
}
