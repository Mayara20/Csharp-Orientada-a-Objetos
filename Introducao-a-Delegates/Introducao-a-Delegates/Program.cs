using System;

namespace Introducao_a_Delegates
{
	delegate void SistemaBinarioNumerico(double i, double j);
	//delegate double SistemaBinarioNumerico(double i, double j);
	class Program
	{
		static void Main(string[] args)
		{
			double a = 4;
			double b = 6;

			SistemaBinarioNumerico sb = CalculandoServicos.Maximo;
			sb += CalculandoServicos.Soma;
			sb(a, b);

			//SistemaBinarioNumerico sb = CalculandoServicos.Maximo;
			//double result = sb(a, b);
			//Console.WriteLine(result);
		}
	}
}
