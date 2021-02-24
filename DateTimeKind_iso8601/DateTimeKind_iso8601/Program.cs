using System;

namespace DateTimeKindee
{
	class Program
	{
		static void Main(string[] args)
		{
			//DateTime d = new DateTime(2000, 10, 01, 21, 15, 30, DateTimeKind.Local);
			//DateTime d1 = new DateTime(2000, 10, 01, 21, 15, 30, DateTimeKind.Utc);
			//DateTime d2 = new DateTime(2000, 10, 01, 21, 15, 30);

			//Console.WriteLine("d:" + d);
			//Console.WriteLine("d. Kind: " + d.Kind);
			//Console.WriteLine("d. Local: " + d.ToLocalTime());
			//Console.WriteLine("d. utc: " + d.ToUniversalTime());
			//Console.WriteLine();
			//Console.WriteLine("d1:" + d1);
			//Console.WriteLine("d1. Kind: " + d1.Kind);
			//Console.WriteLine("d1. Local: " + d1.ToLocalTime());
			//Console.WriteLine("d1. utc: " + d1.ToUniversalTime());
			//Console.WriteLine();
			//Console.WriteLine("d2:" + d2);
			//Console.WriteLine("d2. Kind: " + d2.Kind);
			//Console.WriteLine("d2. Local: " + d2.ToLocalTime());
			//Console.WriteLine("d2. utc: " + d2.ToUniversalTime());
			//Console.WriteLine();
			DateTime M = DateTime.Parse("2000-10-01 21:15:30");
			DateTime M1 = DateTime.Parse("2000-10-01T21:15:30Z");

			Console.WriteLine("M: " + M);
			Console.WriteLine("M Kind: " + M.Kind);
			Console.WriteLine("M Local: " + M.ToLocalTime());
			Console.WriteLine("M Utc: " + M.ToUniversalTime());
			Console.WriteLine("--------------------------------");
			Console.WriteLine(M1);
			Console.WriteLine("M1 Kind: " + M1.Kind);
			Console.WriteLine("M1 Local: " + M1.ToLocalTime());
			Console.WriteLine("M1 Utc: " + M1.ToUniversalTime());
			Console.WriteLine(M1.ToString(" yyyy-MM-ddTHH:mm:ssZ"));
			Console.WriteLine(M1.ToUniversalTime().ToString(" yyyy-MM-ddTHH:mm:ssZ"));

		}
	}
}
