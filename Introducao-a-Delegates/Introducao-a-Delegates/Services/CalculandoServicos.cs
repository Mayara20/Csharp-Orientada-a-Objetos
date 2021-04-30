using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	class CalculandoServicos
	{
		public static void Maximo(double x, double y)
		{
			double maximo = (x > y) ? x : y;
			Console.WriteLine(maximo);
		}
		public static void Soma(double x, double y)
		{
			double soma =  x + y;
			Console.WriteLine(soma);
		}
		//Forma delegate 
		//public static double Maximo(double x, double y)
		//{
		//	return (x > y) ? x : y;
		//}
		//public static double Soma(double x, double y)
		//{
		//	return x + y;
		//}
		//public static double Quadrado(double x)
		//{
		//	return x * x;
		//}
	}
}
