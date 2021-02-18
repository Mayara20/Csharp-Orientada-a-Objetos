using System;

namespace nullable
{
	class Program
	{
		static void Main(string[] args)
		{
			double? x = null;
			double? y = 10;

			double a = x ?? 6;
			double b = y ?? 6;

			Console.WriteLine(x.GetValueOrDefault());
			Console.WriteLine(y.GetValueOrDefault());

			Console.WriteLine(x.HasValue);
			Console.WriteLine(y.HasValue);

			if (x.HasValue)
			{
				Console.WriteLine(x.Value);
			}
			else
			{
				Console.WriteLine("X is null");
			}
			if (y.HasValue)
			{
				Console.WriteLine(y.HasValue);
			}
			else
			{
				Console.WriteLine("Y is null");
			}
			Console.WriteLine(a);
			Console.WriteLine(b);
		}
	}
}
