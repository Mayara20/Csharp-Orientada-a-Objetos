using System;
using System.Collections.Generic;

namespace Exercicio_Proposto_Conjuntos
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> A = new HashSet<int>();
			HashSet<int> B = new HashSet<int>();
			HashSet<int> C = new HashSet<int>();

			Console.Write("Quantos alunos por curso A?");
			int a = int.Parse(Console.ReadLine());
			for(int i = 0; i < a; i++)
			{
				int x = int.Parse(Console.ReadLine());
				A.Add(x);
			}

			Console.Write("Quantos alunos por curso B?");
			int b = int.Parse(Console.ReadLine());
			for (int i = 0; i < b; i++)
			{
				int x = int.Parse(Console.ReadLine());
				B.Add(x);
			}
			Console.Write("Quantos alunos por curso C?");
			int c = int.Parse(Console.ReadLine());
			for (int i = 0; i < c; i++)
			{
				int x = int.Parse(Console.ReadLine());
				B.Add(x);
			}
			A.UnionWith(B);
			B.UnionWith(C);
			C.UnionWith(A);
			Console.WriteLine("Total de Estudantes: " + C.Count);
		}
	}
}
