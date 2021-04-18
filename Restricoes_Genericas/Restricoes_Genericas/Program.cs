using System.Collections.Generic;
using System;
using Restricoes_Genericas.Services;

namespace Restricoes_Genericas
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();

			Console.Write("Entre com o número: ");
			int n = int.Parse(Console.ReadLine());

			for(int i = 0; i < n; i++)
			{
				int x = int.Parse(Console.ReadLine());
				list.Add(x);
			}

			CalculationServices calculation = new CalculationServices();
			int max = calculation.Max(list);

			Console.WriteLine("Max: ");
			Console.WriteLine(max);
		}
	}
}
