using System;
using System.Globalization;

namespace vetores_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine());

			double[] vect = new double[N];

			for(int i = 0; i < N; i++)
			{
				vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			}
			double soma = 0.0;
			for (int i = 0; i < N; i++)
			{
				soma += vect[i];
			}
			double Media = soma / N;

			Console.WriteLine("AVERAGE HEIGHT = " + Media.ToString("F2", CultureInfo.InvariantCulture));
		}
	}
}
