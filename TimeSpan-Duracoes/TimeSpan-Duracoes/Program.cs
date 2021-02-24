using System;

namespace TimeSpan_Duracoes
{
	class Program
	{
		static void Main(string[] args)
		{
			TimeSpan t0 = TimeSpan.FromTicks(900000000L);
			TimeSpan t = new TimeSpan(0, 1, 30);
			TimeSpan t1 = new TimeSpan();
			TimeSpan t2 = new TimeSpan(900000000L);
			TimeSpan t3 = new TimeSpan(2, 11, 21);
			TimeSpan t4 = new TimeSpan(1,2,11,21);
			TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
			TimeSpan t6 = TimeSpan.FromDays(1.5);
			TimeSpan t7 = TimeSpan.FromHours(1.5);
			TimeSpan t8 = TimeSpan.FromMinutes(1.5);
			TimeSpan t9 = TimeSpan.FromSeconds(1.5);
			TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);

			Console.WriteLine(t0);
			Console.WriteLine(t.Ticks);
			Console.WriteLine(t);
			Console.WriteLine(t1);
			Console.WriteLine(t2);
			Console.WriteLine(t3);
			Console.WriteLine(t4);
			Console.WriteLine(t5);
			Console.WriteLine("Days: " + t6);
			Console.WriteLine("Hours: " + t7);
			Console.WriteLine("Minutes: " + t8);
			Console.WriteLine("Seconds: " + t9);
			Console.WriteLine("Milliseconds: " + t10);
		}
	}
}
