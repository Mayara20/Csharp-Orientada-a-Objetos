using System;
using System.Collections.Generic;
using Comparando_Igualdades_Colecoes.Entities;

namespace Comparando_Igualdades_Colecoes
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<Products> a = new HashSet<Products>();
			a.Add(new Products("Televisão", 200.00));
			a.Add(new Products("Geladeira", 5999.00));

			HashSet<Point> b = new HashSet<Point>();
			b.Add(new Point(3, 6));
			b.Add(new Point(2, 8));

			Products prod = new Products("Televisão", 200.00);

			Console.WriteLine(a.Contains(prod));

			Point point = new Point(2, 8);

			Console.WriteLine(b.Contains(point));
		}
	}
}
