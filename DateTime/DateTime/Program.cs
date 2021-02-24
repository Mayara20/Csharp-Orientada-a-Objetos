using System;
using System.Globalization;

namespace DateTimee
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime d = DateTime.Now;
			Console.WriteLine(d);
			Console.WriteLine("----------------------------------");
			DateTime d2 = new DateTime(2021, 02, 22);
			Console.WriteLine(d2);
			Console.WriteLine("----------------------------------");
			DateTime d3 = new DateTime(2021, 02, 22, 17, 12, 10);
			Console.WriteLine(d3);
			Console.WriteLine("----------------------------------");
			DateTime d4 = DateTime.Parse("2000-10-01");
			Console.WriteLine(d4);
			Console.WriteLine("----------------------------------");
			DateTime d5 = DateTime.Parse("2000-10-01 21:15:30");
			Console.WriteLine(d5);
			Console.WriteLine("----------------------------------");
			DateTime d6 = DateTime.ParseExact("10-01-2000", "MM-dd-yyyy", CultureInfo.InvariantCulture);
			Console.WriteLine(d6);
			Console.WriteLine("----------------------------------");
			DateTime d7 = DateTime.ParseExact("2000/10/01 21:15:30", "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
			Console.WriteLine(d7);
			Console.WriteLine("----------------------------------");
		}
	}
}
