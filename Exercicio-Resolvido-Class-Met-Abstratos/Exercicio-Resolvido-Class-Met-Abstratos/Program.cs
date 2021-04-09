using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio_Resolvido_Class_Met_Abstratos.Entities.Enum;
using Exercicio_Resolvido_Class_Met_Abstratos.Entities;

namespace Exercicio_Resolvido_Class_Met_Abstratos
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Figura> figuras = new List<Figura>();

			Console.Write("Entre com o número de figuras: ");
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				Console.WriteLine($"Dados da figura #{i}: ");
				Console.Write("Retângulo ou Círculo (R/C)? ");
				char forma = char.Parse(Console.ReadLine());
				Console.Write("Cor (Preto/Azul/Vermelho): ");
				Cor cor = Enum.Parse<Cor>(Console.ReadLine());
				if (forma == 'R' || forma == 'r')
				{
					Console.Write("Largura: ");
					double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					Console.Write("Altura: ");
					double Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					figuras.Add(new Retângulo(largura, Altura, cor));
				}
				else if(forma == 'C' || forma == 'c')
				{
					Console.Write("Raio: ");
					double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
					figuras.Add(new Circulo(raio, cor));
				}
			}
			Console.WriteLine();
			Console.WriteLine("Áreas de Figuras: ");
			foreach(Figura figura in figuras)
			{
				Console.WriteLine(figura.Area().ToString("F2", CultureInfo.InvariantCulture)); 
			}			
		}
	}
}
