using System;

namespace Propriedades_e_operacoes
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime d = new DateTime(2021, 02, 22, 20, 30, 00, 275);
			Console.WriteLine(d);
			Console.WriteLine("1) Date: " + d.Date);
			Console.WriteLine("2) Day: " + d.Day);
			Console.WriteLine("3) Mês: " + d.Month);
			Console.WriteLine("4) Years: " + d.Year);
			Console.WriteLine("5) Day Of Week: " + d.DayOfWeek);
			Console.WriteLine("6) Day Of Year: " + d.DayOfYear);
			Console.WriteLine("7) Hour: " + d.Hour);
			Console.WriteLine("8) Minute: " + d.Minute);
			Console.WriteLine("9) Second: " + d.Second);
			Console.WriteLine("10) MIllisecond: " + d.Millisecond);
			Console.WriteLine("11) Kind: " + d.Kind);
			Console.WriteLine("12) Time of Day: " + d.TimeOfDay);
			Console.WriteLine("13) Ticks: " + d.Ticks);
			Console.WriteLine(d.ToLongDateString());
			Console.WriteLine(d.ToLongTimeString());
			Console.WriteLine(d.ToShortDateString());
			Console.WriteLine(d.ToShortTimeString());
			string d1 = d.ToString();
			Console.WriteLine(d1);
			string d2 = d.ToString("yyyy-MM-dd HH:mm:ss");
			Console.WriteLine(d2);
			string d3 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
			Console.WriteLine(d3);
		}
	}
}
