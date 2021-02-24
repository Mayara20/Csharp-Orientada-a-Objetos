using System;

namespace Operacoes_com_datetime
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime d = new DateTime(2021, 02, 22, 20, 30, 30);
			DateTime d1 = d.AddHours(2);
			DateTime m = new DateTime(2000, 10, 01, 21, 15, 10);

			DateTime d2 = d.AddMinutes(5);
			DateTime d3 = d.AddSeconds(10);

			Console.WriteLine(d);
			Console.WriteLine(d1);
			Console.WriteLine(d2);
			Console.WriteLine(d3);

			TimeSpan t = d.Subtract(m);
			Console.WriteLine(t);
		}
	}
}
