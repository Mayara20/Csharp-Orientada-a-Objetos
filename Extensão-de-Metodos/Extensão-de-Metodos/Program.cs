using System;
using Extensão_de_Metodos.Extensoes;

namespace Extensão_de_Metodos
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime dt = new DateTime(2021, 04, 17, 10, 15, 30);
			Console.WriteLine(dt.TempoDecorrido());
		}
	}
}
