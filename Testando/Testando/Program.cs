using System;
using System.Globalization;

namespace Testando
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());

			int delta = CalcularDelta(a,b,c);
			Console.WriteLine(delta);
			double x1 = CalcularBhaskara1(b, delta, a); 
			Console.WriteLine(x1);
			double x2 = CalcularBhaskara2(b, delta, a);
			Console.WriteLine(x2);
			
		}
		static double CalcularBhaskara1(int b, int resultadoDelta, int a)
		{
			//(-b + math.sqrt(delta)) / (2 * a);
			double resultadoDeltaPositivo = resultadoDelta * - 1;
			double raizDelta = Math.Sqrt(resultadoDeltaPositivo);
			double x1 = (-b + raizDelta) / (2 * a);
			return x1;
		}

		static double CalcularBhaskara2(int b, int resultadoDelta, int a)
		{
			//(-b - math.sqrt(resultadoDelta)) / (2 * a);
			double resultadoDeltaPositivo = resultadoDelta * -1;
			double x2 = (-b - Math.Sqrt(resultadoDeltaPositivo)) / (2 * a);
			return x2;
		}
		static int CalcularDelta(int a, int b, int c)
		{
			//b*b - 4*a*c
			int resultado = (b * b) - (4 * a * c);
			return resultado;
		}


	}
}
